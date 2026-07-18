# Handson 1 – Creating the First ASP.NET Core Web API

## Objective

To create a basic ASP.NET Core Web API project and implement CRUD operations using an in-memory Employee collection.

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
├── Models
│   └── Employee.cs
│
├── Program.cs
└── EmployeeWebAPI.csproj
```

---

## Implementation Steps

### Step 1

Created a new **ASP.NET Core Web API** project named **EmployeeWebAPI**.

### Step 2

Removed the default WeatherForecast files.

### Step 3

Created an Employee model containing:

- Id
- Name
- Salary
- Permanent

### Step 4

Created an EmployeeController.

### Step 5

Implemented an in-memory list of employees.

### Step 6

Implemented the following REST APIs:

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | /api/Employee | Get all employees |
| GET | /api/Employee/{id} | Get employee by Id |
| POST | /api/Employee | Add employee |
| PUT | /api/Employee/{id} | Update employee |
| DELETE | /api/Employee/{id} | Delete employee |

---

## Testing

The APIs were tested using **Swagger UI**.

Successfully verified:

- Get All Employees
- Get Employee by Id
- Add Employee
- Update Employee
- Delete Employee

---

## Result

Successfully created a RESTful ASP.NET Core Web API implementing CRUD operations using an in-memory Employee list.

---

## Learning Outcome

- Created an ASP.NET Core Web API project.
- Understood Controller and Model architecture.
- Implemented RESTful CRUD APIs.
- Tested APIs using Swagger.