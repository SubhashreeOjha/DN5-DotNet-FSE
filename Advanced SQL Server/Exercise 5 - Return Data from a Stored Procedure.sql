/*=========================================================
Exercise 5 : Return Data from a Stored Procedure
Objective :
Create a stored procedure that returns
employee details based on EmployeeID.
=========================================================*/

USE EmployeeManagementDB;
GO

-------------------------------------------------
-- Drop Procedure if it already exists
-------------------------------------------------

IF OBJECT_ID('sp_GetEmployeeByID','P') IS NOT NULL
    DROP PROCEDURE sp_GetEmployeeByID;
GO

-------------------------------------------------
-- Create Stored Procedure
-------------------------------------------------

CREATE PROCEDURE sp_GetEmployeeByID
    @EmployeeID INT
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
    WHERE EmployeeID = @EmployeeID;
END;
GO

-------------------------------------------------
-- Execute Stored Procedure
-------------------------------------------------

PRINT 'Employee Details';

EXEC sp_GetEmployeeByID 1;
GO

PRINT 'Another Employee';

EXEC sp_GetEmployeeByID 3;
GO