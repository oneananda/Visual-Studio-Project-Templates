# ASP.NET Core Web API with JWT Auth Template

This is a [`dotnet new`](https://docs.microsoft.com/dotnet/core/tools/dotnet-new) template that scaffolds an ASP.NET Core Web API project preconfigured with JSON Web Token (JWT) authentication, in-memory user registration/login, and Swagger support.

---

## Features

* **JWT Authentication**: Configured via `Microsoft.AspNetCore.Authentication.JwtBearer`.
* **User Registration & Login**: Endpoints under `/api/auth/register` and `/api/auth/login` using an in-memory user store.
* **Swagger UI**: Automatically documents and allows testing of your secured endpoints.
* **Template Parameters**:

  * `framework`: Target .NET framework (default: `net7.0`).
  * `--output`: Project directory name and root namespace token replacement.

## Prerequisites

* [.NET SDK 7.0+](https://dotnet.microsoft.com/download)
* Visual Studio 2022 (or later) **or** VS Code with C# extension
* (Optional) [Postman](https://www.postman.com/) or similar for API testing


