/*=========================================================
Exercise 4 : Execute a Stored Procedure
Objective :
Execute the stored procedure to retrieve
employee details for a specific department.
=========================================================*/

USE EmployeeManagementDB;
GO

-------------------------------------------------
-- View all Departments
-------------------------------------------------
SELECT * FROM Departments;
GO

-------------------------------------------------
-- Execute Stored Procedure for HR Department
-------------------------------------------------
PRINT 'Employees in HR Department';

EXEC sp_GetEmployeesByDepartment 1;
GO

-------------------------------------------------
-- Execute Stored Procedure for Finance Department
-------------------------------------------------
PRINT 'Employees in Finance Department';

EXEC sp_GetEmployeesByDepartment 2;
GO

-------------------------------------------------
-- Execute Stored Procedure for IT Department
-------------------------------------------------
PRINT 'Employees in IT Department';

EXEC sp_GetEmployeesByDepartment 3;
GO

-------------------------------------------------
-- Execute Stored Procedure for Marketing Department
-------------------------------------------------
PRINT 'Employees in Marketing Department';

EXEC sp_GetEmployeesByDepartment 4;
GO