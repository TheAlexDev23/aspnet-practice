# What is Anti Forgery?

It's a mechanism that doesn't allow CSRF attacks to happen.

# What is a CSRF attack? 

CSRF stands for Cross Site Forgery Attack. Users might be send to a malicious site with a form sending a POST request to your website.
A browser by default would add cookies of your site alongside the request like for example the session token logging you in automatically.
The attacker might make an action like for example transfering all your money from your bank account into theirs, the browser would add the Banking Site cookies as it always does because the request is sent there. You will be automatically logged in into your wallet and all your money would be sent to the attacker.

# How to fix this?

In razor pages this is autoamtically done. 2 tokens would be generated when sending the user a form as a response:
- A Token for the user.
- A Token for the server.
And when the user would submit the form, alongside the usual cookie the token would also be sent and verified in the server. These tokens are called the anti forgery tokens.
In this way the attacker website request would be rejecected because they don't have a anti forgery token which would always be given to them if the official website would have been loaded.
You can disable this mechanism by adding asp-antiforgery="false" attribute in a `<form>` tag (not reccomended).
