/*=========================================================
Exercise 1 : Create a Stored Procedure
Objective :
1. Create Employee Management Database
2. Create Departments and Employees tables
3. Insert sample data
4. Create a stored procedure to retrieve employees
   by DepartmentID
5. Create a stored procedure to insert a new employee
=========================================================*/

-----------------------------
-- Create Database
-----------------------------
IF DB_ID('EmployeeManagementDB') IS NULL
BEGIN
    CREATE DATABASE EmployeeManagementDB;
END
GO

USE EmployeeManagementDB;
GO

-----------------------------
-- Drop Existing Tables
-----------------------------
DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;
GO

-----------------------------
-- Create Tables
-----------------------------
CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,

    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID)
);
GO

-----------------------------
-- Insert Sample Data
-----------------------------
INSERT INTO Departments VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT'),
(4,'Marketing');

INSERT INTO Employees
(
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    JoinDate
)
VALUES
('John','Doe',1,5000,'2020-01-15'),
('Jane','Smith',2,6000,'2019-03-22'),
('Michael','Johnson',3,7000,'2018-07-30'),
('Emily','Davis',4,5500,'2021-11-05');
GO

/*=========================================================
Stored Procedure 1
Retrieve Employees by Department
=========================================================*/

IF OBJECT_ID('sp_GetEmployeesByDepartment','P') IS NOT NULL
DROP PROCEDURE sp_GetEmployeesByDepartment;
GO

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

/*=========================================================
Stored Procedure 2
Insert Employee
=========================================================*/

IF OBJECT_ID('sp_InsertEmployee','P') IS NOT NULL
DROP PROCEDURE sp_InsertEmployee;
GO

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;
GO

/*=========================================================
Test Stored Procedure
=========================================================*/

PRINT 'Employees in IT Department';

EXEC sp_GetEmployeesByDepartment 3;
GO

PRINT 'Insert New Employee';

EXEC sp_InsertEmployee
'Robert',
'Brown',
2,
6500,
'2024-01-10';
GO

PRINT 'Employees After Insert';

SELECT *
FROM Employees;
GO