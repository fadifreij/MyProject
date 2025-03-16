
To obtain the App ID and App Secret from Facebook, follow these steps:

1. Create a Facebook Developer Account
Go to the Facebook for Developers website.
Log in with your Facebook account.
If you don't already have a developer account, you'll be prompted to create one.

2. Create a New App
add the name of App name
use cases : choose Authenticate and request data from users with Facebook Login
continue until you finish.

3 - go to use cases for the app 
4- click customize
5- on permission click add email
6- click settings on left menu 

set the Valid OAuth Redirect URIs.
Example: https://localhost:5001/signin-facebook
Save your changes.

6. Copy and Use the Credentials
Use the App ID and App Secret in your .NET application configuration: