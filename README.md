# Friendly Phone Number

This is a really simple ASP.Net Core 2 Web API application that acts a service to format a phone number. It's used as an example program for an article at DZone.

It takes simple input:

```
{
  "PhoneNumber" : "5035551212" 
}
```

and returns a JSON object with the phone number formatted;

```
{
  "PhoneNumber" : "(503) 555-1212" 
}
```

This is just a simple service to be used as an example for the article, not intended for production use. 

## DZone Microservices 

Check out DZone's new Microservices section here:

https://dzone.com/microservices-news-tutorials-tools