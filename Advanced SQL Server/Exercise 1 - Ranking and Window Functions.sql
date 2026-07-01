/*=========================================================
Exercise 1 : Ranking and Window Functions
Objective :
Use ROW_NUMBER(), RANK(), DENSE_RANK(), OVER(),
and PARTITION BY to find the Top 3 most expensive
products in each category.
=========================================================*/

-----------------------------
-- Create Database
-----------------------------
IF DB_ID('AdvancedSQLDB') IS NULL
BEGIN
    CREATE DATABASE AdvancedSQLDB;
END
GO

USE AdvancedSQLDB;
GO

-----------------------------
-- Create Categories Table
-----------------------------
IF OBJECT_ID('Categories','U') IS NULL
BEGIN
    CREATE TABLE Categories
    (
        CategoryID INT PRIMARY KEY,
        CategoryName VARCHAR(100)
    );
END
GO

-----------------------------
-- Create Products Table
-----------------------------
IF OBJECT_ID('Products','U') IS NULL
BEGIN
    CREATE TABLE Products
    (
        ProductID INT PRIMARY KEY,
        ProductName VARCHAR(100),
        CategoryID INT,
        Price DECIMAL(10,2),

        FOREIGN KEY(CategoryID)
        REFERENCES Categories(CategoryID)
    );
END
GO

-----------------------------
-- Insert Categories
-----------------------------
IF NOT EXISTS (SELECT * FROM Categories)
BEGIN
    INSERT INTO Categories VALUES
    (1,'Electronics'),
    (2,'Furniture'),
    (3,'Clothing');
END
GO

-----------------------------
-- Insert Products
-----------------------------
IF NOT EXISTS (SELECT * FROM Products)
BEGIN
    INSERT INTO Products VALUES
    (101,'Laptop',1,75000),
    (102,'Mobile',1,45000),
    (103,'Headphones',1,5000),
    (104,'Tablet',1,30000),

    (201,'Chair',2,2500),
    (202,'Table',2,7000),
    (203,'Sofa',2,25000),
    (204,'Cupboard',2,18000),

    (301,'T-Shirt',3,1200),
    (302,'Jeans',3,2200),
    (303,'Jacket',3,4500),
    (304,'Shoes',3,3500);
END
GO

/*=========================================================
Query 1
ROW_NUMBER(), RANK(), DENSE_RANK()
=========================================================*/

SELECT
    c.CategoryName,
    p.ProductName,
    p.Price,

    ROW_NUMBER() OVER
    (
        PARTITION BY c.CategoryName
        ORDER BY p.Price DESC
    ) AS Row_Number,

    RANK() OVER
    (
        PARTITION BY c.CategoryName
        ORDER BY p.Price DESC
    ) AS Rank_Number,

    DENSE_RANK() OVER
    (
        PARTITION BY c.CategoryName
        ORDER BY p.Price DESC
    ) AS Dense_Rank_Number

FROM Products p
JOIN Categories c
ON p.CategoryID = c.CategoryID;

PRINT '-------------------------------------------';
PRINT 'Top 3 Most Expensive Products in Each Category';
PRINT '-------------------------------------------';

/*=========================================================
Query 2
Top 3 Products in Each Category
=========================================================*/

WITH ProductRanking AS
(
    SELECT
        c.CategoryName,
        p.ProductName,
        p.Price,

        ROW_NUMBER() OVER
        (
            PARTITION BY c.CategoryName
            ORDER BY p.Price DESC
        ) AS RowNum

    FROM Products p
    JOIN Categories c
    ON p.CategoryID = c.CategoryID
)

SELECT
    CategoryName,
    ProductName,
    Price,
    RowNum
FROM ProductRanking
WHERE RowNum <= 3
ORDER BY CategoryName, RowNum;