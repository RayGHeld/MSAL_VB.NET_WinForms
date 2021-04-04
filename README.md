# MSAL_VB.NET_WinForms
Using MSAL in a Vb.Net Winforms desktop application

This sample shows how to use MSAL.net in a VB.Net WinForms application.  To test this sample, you must first create an app registration in your Azure tenant.  For the redirect URI,
add a new platform of "Mobile and desktop applications" and set the address to "http://localhost".  The only permission required for this sample is the Microsoft Graph permission
"User.Read", which is already added by default when you create the application registration.  Create a client_secret for the app registration as well ( note the value that is
created as it will not be displayed again).

In Form1.vb, set the client_id, client_secret and tenant_id private variables at teh top of the form.

