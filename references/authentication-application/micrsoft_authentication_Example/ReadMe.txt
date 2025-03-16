Steps to Register Your App in Azure portal ( free no need to add subscription )

Sign in to Azure Portal:

Visit https://portal.azure.com and sign in with your Microsoft account.
Access Azure Active Directory:

In the left sidebar, find "Azure Active Directory" (you can also search for it in the top search bar).
App Registrations:

In the Azure AD menu, select "App registrations".
Click "New registration".

Register Your Application:

Name: Choose a name for your app.
Supported account types
Accounts in any organizational directory (Any Microsoft Entra ID tenant - Multitenant) and personal Microsoft accounts (e.g. Skype, Xbox)

Redirect URI
https://localhost:[same port on you project]/signin-microsoft


Copy client ID after save 

after that go to Certificates & secrets create new secret copy it and past it in you application