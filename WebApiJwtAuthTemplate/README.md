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

## Installation

1. Clone or download this folder (containing `.template.config/template.json`).
2. Open a terminal in the root folder:

   ```bash
   dotnet new -i .
   ```

   This installs the template into your local `dotnet new` catalog.

## Usage

Create a new project using the template:

```bash
# Replace MyApi with your desired project name (and namespace)
dotnet new webapi-jwt -n MyApi --framework net7.0
cd MyApi
dotnet run
```

Your API will launch on `https://localhost:5001` (or similar). Navigate to `/swagger/index.html` to access Swagger UI.

---

## Configuration

### appsettings.json

```json
{
  "JwtSettings": {
    "Key": "YourSuperSecretKey_123!",
    "Issuer": "YourApp",
    "Audience": "YourAppUsers",
    "DurationInMinutes": 60
  },
  "AllowedHosts": "*"
}
```

* **Key**: Symmetric key for signing tokens (use a strong, secret value in production).
* **Issuer** / **Audience**: Token validation parameters.
* **DurationInMinutes**: Token lifetime.

### Program.cs

* Configures dependency injection for `IUserService`.
* Wires up JWT Bearer authentication using the above settings.

---
