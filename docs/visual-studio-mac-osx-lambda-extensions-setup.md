# Install Visual Studio Lambda Tools Extensions - Mac OSX

1. Install Visual Studio For MAC
2. Install Visual Studio Lambda Tools extensions (Use Terminal) dotnet tool install -g Amazon.Lambda.Tools
3. Install Visual Studio Lambda Templates (Use Terminal) - dotnet new -i Amazon.Lambda.Templates
4. In Terminal prompt, Enter: dotnet new -all to search for all installed templates. You should see the Lambda and serverless templates appear here.
5. To create a serverless template (Use Terminal): dotnet new serverless.AspNetCoreWebAPI -n SwaggerAPILambda -p default -r eu-west-1