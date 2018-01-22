# AspNetCoreVersionedWebApi

[![Build status](https://ci.appveyor.com/api/projects/status/9i3n48g9b8jdqdju?svg=true)](https://ci.appveyor.com/project/PaddoSwam/aspnetcoreversionedwebapi)

A demonstration how to create a versioned and documented Web API project with .NET Core using.

The guide to this project can be found on my website:

[https://tomhofman.nl/lets-create-versioned-documented-asp-net-core-web-api](https://tomhofman.nl/lets-create-versioned-documented-asp-net-core-web-api/)

```powershell
dotnet restore
dotnet run --project VersionedWebApi\\VersionedWebApi.csproj
```

Visit http://localhost:5000/api/v1/hello and http://localhost:5000/api/v2/hello for the demonstration.

**NuGet:** [www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Versioning](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Versioning)

**GitHub:** [github.com/domaindrivendev/Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

**GitHub:** [github.com/rh072005/SwashbuckleAspNetVersioningShim](https://github.com/rh072005/SwashbuckleAspNetVersioningShim)
