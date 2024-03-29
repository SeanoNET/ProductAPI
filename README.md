# ProductAPI
A simple ASP Net core product web API to get more familiar with .NET Core 3 and EF Core based on [Create a web API with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.0&tabs=visual-studio)


## Swagger / OpenAPI

NSwag was implemented based on [Get started with NSwag and ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.0&tabs=visual-studio) also see [ASP.NET Core web API help pages with Swagger / OpenAPI](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-3.0)

You can view the Swagger UI by navigating to `https://localhost:<port>/swagger`

A Swagger client was generated using [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) in `ProductClient`.

## Docker

This API runs inside of a docker container, for more info see [Dockerize an ASP.NET Core application](https://docs.docker.com/engine/examples/dotnetcore/)

## Auth
Identity Server 4 has been configured see [Identity Server Overview](http://docs.identityserver.io/en/latest/quickstarts/0_overview.html). Provider server can be found in []() or you can use the [Demo Server](http://docs.identityserver.io/en/latest/intro/test.html)