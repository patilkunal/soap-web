# soap-web
SOAP Webservice using .NET Framework

## Steps to get working on Windows/Linux/MacOS
Install DOT NET Framework from there https://docs.microsoft.com/en-us/dotnet/core/install/
Best way to get to compile and run, is to use Visual Studio Code and install C# Plugin and extensions

This project was created using steps described here https://dottutorials.net/creating-soap-web-services-dot-net-core-tutorial (https://dottutorials.net/creating-soap-web-services-dot-net-core-tutorial/)

```
dotnet new web
dotnet add package SoapCore
```
Run your project and point your browser to http://localhost:5000/Services.asmx (http://localhost:5000/Services.asmx)
Test your SOAP Webservice using SOAP UI and importing WSDL from above link

More can be found at Microsoft Documentation (https://docs.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-3.1&tabs=linux)