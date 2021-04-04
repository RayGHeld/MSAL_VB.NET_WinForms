<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.txtBoxAccessToken = New System.Windows.Forms.TextBox()
        Me.txtboxIDToken = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClientCredentials = New System.Windows.Forms.Button()
        Me.txtBoxScopes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSignIn
        '
        Me.btnSignIn.Location = New System.Drawing.Point(12, 12)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(148, 23)
        Me.btnSignIn.TabIndex = 0
        Me.btnSignIn.Text = "Sign In Interactive"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'txtBoxAccessToken
        '
        Me.txtBoxAccessToken.Location = New System.Drawing.Point(12, 253)
        Me.txtBoxAccessToken.Multiline = True
        Me.txtBoxAccessToken.Name = "txtBoxAccessToken"
        Me.txtBoxAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBoxAccessToken.Size = New System.Drawing.Size(776, 185)
        Me.txtBoxAccessToken.TabIndex = 1
        '
        'txtboxIDToken
        '
        Me.txtboxIDToken.Location = New System.Drawing.Point(12, 75)
        Me.txtboxIDToken.Multiline = True
        Me.txtboxIDToken.Name = "txtboxIDToken"
        Me.txtboxIDToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtboxIDToken.Size = New System.Drawing.Size(776, 142)
        Me.txtboxIDToken.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id Token:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Access Token"
        '
        'btnClientCredentials
        '
        Me.btnClientCredentials.Location = New System.Drawing.Point(507, 44)
        Me.btnClientCredentials.Name = "btnClientCredentials"
        Me.btnClientCredentials.Size = New System.Drawing.Size(148, 23)
        Me.btnClientCredentials.TabIndex = 5
        Me.btnClientCredentials.Text = "Sign in Client Credentials"
        Me.btnClientCredentials.UseVisualStyleBackColor = True
        '
        'txtBoxScopes
        '
        Me.txtBoxScopes.Location = New System.Drawing.Point(507, 18)
        Me.txtBoxScopes.Name = "txtBoxScopes"
        Me.txtBoxScopes.Size = New System.Drawing.Size(281, 20)
        Me.txtBoxScopes.TabIndex = 6
        Me.txtBoxScopes.Text = "https://graph.microsoft.com/.default"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(458, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Scopes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBoxScopes)
        Me.Controls.Add(Me.btnClientCredentials)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxIDToken)
        Me.Controls.Add(Me.txtBoxAccessToken)
        Me.Controls.Add(Me.btnSignIn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSignIn As Button
    Friend WithEvents txtBoxAccessToken As TextBox
    Friend WithEvents txtboxIDToken As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClientCredentials As Button
    Friend WithEvents txtBoxScopes As TextBox
    Friend WithEvents Label3 As Label
End Class
