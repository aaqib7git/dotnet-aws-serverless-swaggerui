# AWS Serverless Swagger Lambda Sample Application

This shows an example of accessing Swagger UI on an AWS Serverless application composed of an API Gateway and .NET Core Lambda.

# MAC OS Setup

1. Install Visual Studio For MAC
2. Install Visual Studio Lambda Tools extensions - dotnet tool install -g Amazon.Lambda.Tools
3. Install Visual Studio Lambda Templates - dotnet new -i Amazon.Lambda.Templates
4. Enter: dotnet new -all to search for all installed templates. You should see the Lambda and serverless templates appear here.
5. To create a serverless template: dotnet new serverless.AspNetCoreWebAPI -n SwaggerAPILambda -p default -r eu-west-1