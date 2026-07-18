# Handson 2 – Testing Web API using Swagger and Postman

## Objective

To configure Swagger for API documentation and test Web API endpoints using both Swagger UI and Postman.

---

## Technologies Used

- ASP.NET Core 8.0 Web API
- Swagger (Swashbuckle)
- Postman
- Visual Studio 2022

---

## Implementation Steps

### Step 1

Configured Swagger in the ASP.NET Core Web API project.

### Step 2

Verified that the Swagger UI loads successfully on application startup.

### Step 3

Modified the API route from:

```csharp
[Route("api/[controller]")]
```

to

```csharp
[Route("api/Emp")]
```

### Step 4

Executed all API endpoints using Swagger UI.

### Step 5

Tested the same endpoints using Postman by sending HTTP requests.

The following operations were verified:

| HTTP Method | Endpoint | Description |
|-------------|----------|-------------|
| GET | /api/Emp | Retrieve all employees |
| GET | /api/Emp/{id} | Retrieve employee by Id |
| POST | /api/Emp | Create a new employee |
| PUT | /api/Emp/{id} | Update an existing employee |
| DELETE | /api/Emp/{id} | Delete an employee |

---

## Testing

Successfully executed all CRUD operations using:

- Swagger UI
- Postman

Verified appropriate HTTP status codes and JSON responses for each request.

---

## Result

Successfully configured Swagger for API documentation and validated all REST endpoints using both Swagger and Postman.

---

## Learning Outcome

- Learned API documentation using Swagger.
- Understood testing REST APIs using Postman.
- Practiced sending HTTP requests and interpreting responses.
- Verified CRUD operations through multiple testing tools.