# ASP.NET Core Identity Auth Server

## Summary

This is a sample project using ASP.Net Core Identity to create an Auth Server API.

### Architecture
This project is structured usgin a Clean Architecture with 4 layers:

- AuthServer.API
- AuthServer.Application
- AuthServer.Domain
- AuthServer.Infrastructure


## ASP.NET Core Identity database configuration

Run this command on the solution root folder to add the initial migration on a folder called Data/Migrations inside of the Infrastructure project:

```bash
dotnet ef migrations add CreateIdentityTables --project src/AuthServer.Infrastructure --startup-project src/AuthServer.API --output-dir Data/Migrations
```

Now run this command to update the database:

```bash
dotnet ef database update --project src/AuthServer.Infrastructure --startup-project src/AuthServer.API
```