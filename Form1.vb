Imports System.Text
Imports Microsoft.Identity.Client

Public Class Form1

    Private accessToken As String = String.Empty
    Private idToken As String = String.Empty

    Private client_id As String = ""
    Private client_secret As String = ""
    Private tenant_id As String = ""
    Private redirect_uri As String = "http://localhost"
    Private scopes() As String = New String() {"openid offline_access profile "}

    Private errors As New Stack(Of String)

    Private isLoggedIn As Boolean = False

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        txtboxIDToken.Text = String.Empty
        txtBoxAccessToken.Text = String.Empty

        idToken = String.Empty
        accessToken = String.Empty

        'we need a task to get MSAL to log us in
        If (txtBoxScopes.Text.Length > 0) Then
            Try
                Dim _scopes() As String = txtBoxScopes.Text.Split(" ")
                scopes = _scopes
            Catch ex As Exception
                MessageBox.Show("Invalid scopes parameter... resetting to openid offline_access profile")
                txtBoxScopes.Text = "openid offline_access profile"
                txtBoxScopes.Focus()
                txtBoxScopes.SelectAll()
                Exit Sub
            End Try
        End If

        Dim task = New Task(AddressOf LoginInteractively)
        task.Start()
        task.Wait()

        If errors.Count > 0 Then
            Dim error_messages As New StringBuilder()
            Do Until errors.Count <= 0
                If error_messages.Length > 0 Then
                    error_messages.Append(ControlChars.NewLine)
                End If
                error_messages.Append(errors.Pop())
            Loop
            MessageBox.Show($"Errors encountered: {error_messages.ToString()}")
        End If

    End Sub

    Private Sub btnClientCredentials_Click(sender As Object, e As EventArgs) Handles btnClientCredentials.Click
        txtboxIDToken.Text = String.Empty
        txtBoxAccessToken.Text = String.Empty

        idToken = String.Empty
        accessToken = String.Empty

        'we need a task to get MSAL to log us in
        If (txtBoxScopes.Text.Length > 0) Then
            Try
                Dim _scopes() As String = txtBoxScopes.Text.Split(" ")
                scopes = _scopes
            Catch ex As Exception
                MessageBox.Show("Invalid scopes parameter... resetting to https://graph.microsoft.com/.default")
                txtBoxScopes.Text = "https://graph.microsoft.com/.default"
                txtBoxScopes.Focus()
                txtBoxScopes.SelectAll()
                Exit Sub
            End Try
        End If

        Dim task = New Task(AddressOf LoginClientCredentials)
        task.Start()
        task.Wait()

        If errors.Count > 0 Then
            Dim error_messages As New StringBuilder()
            Do Until errors.Count <= 0
                If error_messages.Length > 0 Then
                    error_messages.Append(ControlChars.NewLine)
                End If
                error_messages.Append(errors.Pop())
            Loop
            MessageBox.Show($"Errors encountered: {error_messages.ToString()}")
        End If

    End Sub

    Private Async Sub LoginInteractively()
        Try
            Dim app As IPublicClientApplication = PublicClientApplicationBuilder.Create(client_id).WithRedirectUri(redirect_uri).WithTenantId(tenant_id).WithAuthority(AadAuthorityAudience.AzureAdMyOrg).Build()
            Dim authResult As AuthenticationResult = Nothing

            Dim accounts As IEnumerable(Of IAccount) = Await app.GetAccountsAsync()
            Dim performInterativeFlow As Boolean = False

            Try
                authResult = Await app.AcquireTokenSilent(scopes, accounts.FirstOrDefault()).ExecuteAsync()
            Catch ex As MsalUiRequiredException
                performInterativeFlow = True
            Catch ex As Exception
                errors.Push(ex.Message)
            End Try

            If performInterativeFlow Then
                authResult = Await app.AcquireTokenInteractive(scopes).ExecuteAsync()
            End If

            If authResult.AccessToken <> String.Empty Then
                accessToken = authResult.AccessToken
                idToken = authResult.IdToken
            End If

        Catch ex As Exception
            errors.Push(ex.Message)
            Exit Sub
        End Try

        'Since this thread runs under the ui thread, we need a delegate method to update the text boxes
        txtBoxAccessToken.BeginInvoke(New InvokeDelegate(AddressOf InvokeMethod))

        Return
    End Sub

    Private Async Sub LoginClientCredentials()

        Dim authResult As AuthenticationResult = Nothing

        Try
            Dim app As IConfidentialClientApplication = ConfidentialClientApplicationBuilder.Create(client_id).WithClientSecret(client_secret).WithTenantId(tenant_id).WithAuthority(AadAuthorityAudience.AzureAdMyOrg).Build()
            authResult = Await app.AcquireTokenForClient(scopes).ExecuteAsync()
        Catch ex As Exception
            errors.Push(ex.Message)
            Exit Sub
        End Try

        accessToken = authResult.AccessToken
        idToken = "No id token given for this auth flow."

        'Since this thread runs under the ui thread, we need a delegate method to update the text boxes
        txtBoxAccessToken.BeginInvoke(New InvokeDelegate(AddressOf InvokeMethod))
    End Sub

    Private Delegate Sub InvokeDelegate()
    Private Sub InvokeMethod()
        txtBoxAccessToken.Text = accessToken
        txtboxIDToken.Text = idToken
    End Sub


End Class

