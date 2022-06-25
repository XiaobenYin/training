--1. 
Drop VIEW view_product_order_Yin
CREATE VIEW view_product_order_Yin
AS
SELECT p.ProductName, SUM(od.Quantity) TotalOrderQuantities 
FROM Products p JOIN [Order Details] od ON p.ProductID=od.ProductID 
GROUP BY P.ProductName

SELECT *
FROM view_product_order_Yin

--2.
CREATE PROC sp_product_order_quantity_Yin 
@ProductID INT,
@TotalOrderQuantities INT OUT
AS
SELECT @TotalOrderQuantities=TotalOrderQuantities 
FROM 
(
SELECT p.ProductID, SUM(od.Quantity) TotalOrderQuantities 
FROM Products p JOIN [Order Details] od ON p.ProductID=od.ProductID 
GROUP BY P.ProductID
) dt 
WHERE dt.ProductID = @ProductID
--try to execute the stored procedure
/*
DECLARE @TotalOrderQuantities INT
EXEC sp_product_order_quantity_Yin 1, @TotalOrderQuantities OUT 
SELECT @TotalOrderQuantities Total_Quantity
*/
--DROP PROCEDURE dbo.sp_product_order_quantity_Yin  

--3.
CREATE PROC sp_product_order_city_Yin
@ProductName VARCHAR(20),
@City VARCHAR(20) OUT,
@TotalQuantity INT OUT
AS 
SELECT @City=City, @TotalQuantity=TotalQuantity
FROM
(SELECT City, ProductName, TotalQuantity, RNK
FROM
(
SELECT p.ProductName, c.City, SUM(od.Quantity) TotalQuantity, RANK() OVER(PARTITION BY p.ProductName ORDER BY SUM(od.Quantity) DESC) RNK 
FROM Products p JOIN [Order Details] od ON od.ProductID=p.ProductID JOIN Orders o ON o.OrderID=od.OrderID JOIN Customers c ON o.CustomerID=c.CustomerID
GROUP BY p.ProductName, c.City 
) dt 
WHERE RNK <= 5) dt2
WHERE ProductName = @ProductName

DECLARE @City VARCHAR(20), @TotalQuantity INT
EXEC sp_product_order_city_Yin 'Alice Mutton', @City OUT, @TotalQuantity OUT
SELECT @City, @TotalQuantity

--DROP PROCEDURE dbo.sp_product_order_city_Yin

--4. 
CREATE TABLE people_Yin
(id INT,
Name VARCHAR(20),
City INT
)

CREATE TABLE city_Yin
(id INT,
City VARCHAR(20)
)

INSERT INTO people_Yin VALUES(1, 'Aaron Rodgers', 2)
INSERT INTO people_Yin VALUES(2, 'Russell Wilson', 1) 
INSERT INTO people_Yin VALUES(3, 'Jody Nelson', 2)

INSERT INTO city_Yin VALUES(1, 'Seattle')
INSERT INTO city_Yin VALUES(2, 'Green Bay')
SELECT * FROM people_Yin
SELECT * FROM city_Yin

-- SELECT p.Name FROM people_Yin p JOIN city_Yin c ON p.city=c.id WHERE c.City='Seattle'

CREATE VIEW Packers_XiaobenYin
AS
SELECT p.Name FROM people_Yin p JOIN city_Yin c ON p.city=c.id WHERE c.City='Green Bay'
 
SELECT * FROM Packers_XiaobenYin
Drop View Packers_XiaobenYin
DROP TABLE people_Yin
DROP TABLE city_Yin
-- SELECT * FROM Packers_XiaobenYin

--5.
CREATE PROC sp_birthday_employees_Yin
AS
BEGIN
SELECT * INTO birthday_employees_Yin 
FROM Employees e 
WHERE MONTH(BirthDate) = '02'
END

BEGIN
EXEC sp_birthday_employees_Yin
END

SELECT * 
FROM birthday_employees_Yin
DROP TABLE birthday_employees_Yin
DROP PROC sp_birthday_employees_Yin

--6.
/*
We can use UNION clause to check, if the output has the same number of rows as the original tables, it means that two tables are the same.
*/
