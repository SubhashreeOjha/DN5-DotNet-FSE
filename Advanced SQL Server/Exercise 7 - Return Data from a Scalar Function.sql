/*=========================================================
Exercise 7 : Return Data from a Scalar Function
Objective :
Create a Scalar Function that returns
the Annual Salary of an Employee.
=========================================================*/

USE EmployeeManagementDB;
GO

-------------------------------------------------
-- Drop Function if it already exists
-------------------------------------------------

IF OBJECT_ID('fn_GetAnnualSalary','FN') IS NOT NULL
    DROP FUNCTION fn_GetAnnualSalary;
GO

-------------------------------------------------
-- Create Scalar Function
-------------------------------------------------

CREATE FUNCTION fn_GetAnnualSalary
(
    @EmployeeID INT
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @AnnualSalary DECIMAL(10,2);

    SELECT
        @AnnualSalary = Salary * 12
    FROM Employees
    WHERE EmployeeID = @EmployeeID;

    RETURN @AnnualSalary;
END;
GO

-------------------------------------------------
-- Test the Scalar Function
-------------------------------------------------

SELECT
    EmployeeID,
    FirstName,
    LastName,
    Salary,
    dbo.fn_GetAnnualSalary(EmployeeID) AS AnnualSalary
FROM Employees;
GO