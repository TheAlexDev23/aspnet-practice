# What is HSTS?

HSTS stands for `HTTP Strict Transport Security`, in ASP.NET Core this means that when enabled a header would be added to the response saying that all the following consecutivce requests should use HTTPS instead of HTTP.
In my case I set it to use HSTS for 1 hour, so when 1 hour runs out the browser would sent HTTP again as it does always by default

# Important to know

HSTS only works when a HTTPS request is already sent in the first place (which doesn't happen by default). That's why a HTTPSRedirectionMiddelware is needed in our middleware pipeline.
