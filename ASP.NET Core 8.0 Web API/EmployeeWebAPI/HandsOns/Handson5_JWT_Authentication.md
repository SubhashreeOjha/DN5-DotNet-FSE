# Handson 5 – JWT Authentication and Authorization

## Objective

To secure the Employee Web API using JSON Web Token (JWT) authentication and implement role-based authorization for protected endpoints.

---

## Technologies Used

- ASP.NET Core 8.0 Web API
- JWT Bearer Authentication
- C#
- Visual Studio 2022
- Swagger UI
- Postman

---

## Project Structure

```
EmployeeWebAPI
│
├── Controllers
│   ├── AuthController.cs
│   └── EmployeeController.cs
│
├── Filters
│   └── CustomExceptionFilter.cs
│
├── Program.cs
└── appsettings.json
```

---

## Implementation Steps

### Step 1

Installed the required NuGet packages:

- Microsoft.AspNetCore.Authentication.JwtBearer
- System.IdentityModel.Tokens.Jwt

### Step 2

Configured JWT Authentication in `Program.cs` by:

- Defining a secret key
- Configuring JWT Bearer authentication
- Setting issuer and audience validation
- Enabling token lifetime validation

### Step 3

Created an `AuthController` to generate JWT tokens.

The generated token contains:

- User Id
- User Role
- Expiration Time

### Step 4

Protected the Employee API using:

```csharp
[Authorize]
```

Only authenticated users can access the endpoints.

### Step 5

Implemented role-based authorization using:

```csharp
[Authorize(Roles = "POC")]
```

and

```csharp
[Authorize(Roles = "Admin,POC")]
```

to verify access based on user roles.

---

## Testing

The following scenarios were tested successfully using Postman:

| Scenario | Expected Result |
|----------|-----------------|
| Generate JWT Token | 200 OK |
| Access API without Token | 401 Unauthorized |
| Access API with Valid Token | 200 OK |
| Access API with Expired Token | 401 Unauthorized |
| Access API with Invalid Role | 403 Forbidden |
| Access API with Authorized Role | 200 OK |

---

## Result

Successfully secured the Web API using JWT authentication and implemented role-based authorization to restrict access to protected resources.

---

## Learning Outcome

- Understood JWT authentication in ASP.NET Core.
- Generated and validated JWT tokens.
- Protected APIs using the `[Authorize]` attribute.
- Implemented role-based authorization.
- Tested authentication and authorization using Postman.
- Learned the difference between **401 Unauthorized** and **403 Forbidden** responses.