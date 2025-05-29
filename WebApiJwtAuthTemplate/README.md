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

## Extending & Customization

* **Persisted Users**: Replace the in-memory `UserService` with EF Core, Dapper, or another store:

  * Register your `DbContext` and swap `builder.Services.AddSingleton<IUserService, UserService>()` accordingly.

* **Role-Based Authorization**: Add roles as JWT claims in `AuthController.Login`, then decorate controllers/actions with `[Authorize(Roles = "Admin")]`.

* **Token Refresh**: Implement a refresh-token endpoint and store refresh tokens per user (e.g., in a database).

* **Additional Template Symbols**: Extend `.template.config/template.json` with new `symbols` (e.g., `useSwagger`, `useEFCore`) to conditionally include/exclude features via `dotnet new` flags.

---

## Packaging & Distribution

To publish your template as a NuGet package:

```bash
dotnet pack --configuration Release
# then push to NuGet.org
dotnet nuget push bin/Release/YourCompany.WebApiJwtAuth.*.nupkg -s https://api.nuget.org/v3/index.json
```

Users can then install directly by referencing the NuGet package:

```bash
dotnet new -i YourCompany.WebApiJwtAuth::1.0.0
```

---

## License

This template is provided under the MIT License. See `LICENSE` for details.

