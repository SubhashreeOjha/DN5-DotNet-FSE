# Handson 3 – Custom Models, Authentication Filter and Exception Filter

## Objective

To enhance the Web API by creating custom models, implementing a custom authentication filter, and handling exceptions using a custom exception filter.

---

## Technologies Used

- ASP.NET Core 8.0 Web API
- C#
- Visual Studio 2022
- Swagger UI

---

## Project Structure

```
EmployeeWebAPI
│
├── Controllers
│   └── EmployeeController.cs
│
├── Filters
│   ├── CustomAuthFilter.cs
│   └── CustomExceptionFilter.cs
│
├── Models
│   ├── Employee.cs
│   ├── Department.cs
│   └── Skill.cs
```

---

## Implementation Steps

### Step 1

Created the following models:

- Employee
- Department
- Skill

### Step 2

Updated the Employee model to include:

- Id
- Name
- Salary
- Permanent
- Department
- Skills
- DateOfBirth

### Step 3

Implemented a custom authentication filter (`CustomAuthFilter`) to validate the Authorization header.

Validation performed:

- Authorization header missing
- Bearer token missing

Returned appropriate Bad Request responses for invalid requests.

### Step 4

Applied the authentication filter to the EmployeeController.

### Step 5

Implemented a custom exception filter (`CustomExceptionFilter`) to:

- Capture unhandled exceptions
- Log exception details into `ExceptionLog.txt`
- Return HTTP 500 (Internal Server Error)

### Step 6

Registered the exception filter using dependency injection in `Program.cs`.

### Step 7

Tested the exception filter by intentionally throwing an exception and verifying that:

- Exception was logged
- Client received HTTP 500 response

### Step 8

Restored the controller to normal execution after successful testing.

---

## Testing

Successfully verified:

- Employee retrieval
- Authentication header validation
- Invalid Authorization requests
- Global exception handling
- Exception logging
- HTTP 500 responses

---

## Result

Successfully implemented reusable custom authentication and exception filters, improving the security and reliability of the Web API.

---

## Learning Outcome

- Created complex models with nested objects.
- Implemented custom Action Filters.
- Implemented global exception handling.
- Used Dependency Injection for filter registration.
- Learned centralized error handling in ASP.NET Core.