/*=========================================================
Exercise : Index
Objective :
1. Create a Non-Clustered Index
2. Create a Composite Index
=========================================================*/

-----------------------------
-- Create Database
-----------------------------
IF DB_ID('RetailStoreDB') IS NULL
BEGIN
    CREATE DATABASE RetailStoreDB;
END
GO

USE RetailStoreDB;
GO

-----------------------------
-- Drop Existing Tables
-----------------------------
DROP TABLE IF EXISTS OrderDetails;
DROP TABLE IF EXISTS Orders;
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Customers;
GO

-----------------------------
-- Create Tables
-----------------------------
CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Region VARCHAR(50)
);

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
);
GO

-----------------------------
-- Insert Data
-----------------------------
INSERT INTO Customers VALUES
(1,'Alice','North'),
(2,'Bob','South'),
(3,'Charlie','East'),
(4,'David','West');

INSERT INTO Products VALUES
(1,'Laptop','Electronics',1200),
(2,'Smartphone','Electronics',800),
(3,'Tablet','Electronics',600),
(4,'Headphones','Accessories',150);

INSERT INTO Orders VALUES
(1,1,'2023-01-15'),
(2,2,'2023-02-20'),
(3,3,'2023-03-25'),
(4,4,'2023-04-30');

INSERT INTO OrderDetails VALUES
(1,1,1,1),
(2,2,2,2),
(3,3,3,1),
(4,4,4,3);
GO

------------------------------------------------------------
-- Exercise 1 : Create a Non-Clustered Index
------------------------------------------------------------

CREATE NONCLUSTERED INDEX IX_ProductName
ON Products(ProductName);
GO

PRINT 'Non-Clustered Index Created Successfully';

SELECT *
FROM Products
WHERE ProductName = 'Laptop';
GO

------------------------------------------------------------
-- Exercise 2 : Create a Composite Index
------------------------------------------------------------

CREATE NONCLUSTERED INDEX IX_Customer_OrderDate
ON Orders(CustomerID, OrderDate);
GO

PRINT 'Composite Index Created Successfully';

SELECT *
FROM Orders
WHERE CustomerID = 1
AND OrderDate = '2023-01-15';
GO

------------------------------------------------------------
-- Display Created Indexes
------------------------------------------------------------

SELECT
    name AS IndexName,
    type_desc AS IndexType,
    OBJECT_NAME(object_id) AS TableName
FROM sys.indexes
WHERE OBJECT_NAME(object_id) IN ('Products','Orders');
GO