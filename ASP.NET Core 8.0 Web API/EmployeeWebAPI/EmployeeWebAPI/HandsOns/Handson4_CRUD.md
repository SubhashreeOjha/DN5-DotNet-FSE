# Handson 4 – CRUD Operations with Validation

## Objective

To enhance the Employee Web API by implementing CRUD operations with proper input validation and meaningful HTTP responses.

---

## Technologies Used

- ASP.NET Core 8.0 Web API
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
│   └── EmployeeController.cs
│
├── Models
│   ├── Employee.cs
│   ├── Department.cs
│   └── Skill.cs
```

---

## Implementation Steps

### Step 1

Implemented CRUD operations for Employee resources:

- Create Employee
- Retrieve Employee(s)
- Update Employee
- Delete Employee

### Step 2

Enhanced the **PUT** endpoint with input validation.

Validation performed:

- Employee Id should be greater than zero.
- Employee should exist before updating.
- Return appropriate error messages for invalid requests.

Example validation logic:

- Invalid Id → **400 Bad Request**
- Employee not found → **400 Bad Request**
- Successful update → **200 OK**

### Step 3

Returned meaningful HTTP status codes and responses for all CRUD operations.

---

## API Endpoints

| HTTP Method | Endpoint | Description |
|-------------|----------|-------------|
| GET | /api/Employee | Retrieve all employees |
| GET | /api/Employee/{id} | Retrieve employee by Id |
| POST | /api/Employee | Create a new employee |
| PUT | /api/Employee/{id} | Update an existing employee |
| DELETE | /api/Employee/{id} | Delete an employee |

---

## Testing

The API was tested using Swagger UI and Postman.

The following scenarios were verified successfully:

- Retrieve all employees
- Retrieve employee by Id
- Add a new employee
- Update an existing employee
- Delete an employee
- Invalid employee Id
- Employee not found
- Successful update operation

---

## Result

Successfully implemented complete CRUD functionality with proper validation and meaningful HTTP responses.

---

## Learning Outcome

- Implemented RESTful CRUD operations.
- Performed server-side input validation.
- Returned appropriate HTTP status codes.
- Improved API reliability through validation checks.
- Tested CRUD APIs using Swagger and Postman.