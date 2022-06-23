--1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
SELECT cr.Name Country, sp.Name Province
FROM Person.CountryRegion cr JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode

--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
SELECT cr.Name Country, sp.Name Province
FROM Person.CountryRegion cr JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name IN ('Germany', 'Canada')

--3. List all Products that has been sold at least once in last 25 years.
SELECT p.ProductName, COUNT(o.OrderID) NumofOrders
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE DATEDIFF(YEAR, o.OrderDate, GETDATE()) <= 25
GROUP BY p.ProductName
HAVING count(o.OrderID)>=1

--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 o.ShipPostalCode, COUNT(o.ShipPostalCode) NumofProducts
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE DATEDIFF(YEAR, o.OrderDate, GETDATE()) <= 25
GROUP BY o.ShipPostalCode
ORDER BY NumofProducts DESC

--5. List all city names and number of customers in that city.   
SELECT c.City, COUNT(c.CustomerID) NumofCustomers
FROM Customers c
GROUP BY c.City

--6. List city names which have more than 2 customers, and number of customers in that city
SELECT c.City, COUNT(c.CustomerID) NumofCustomers
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) > 2

--7. Display the names of all customers along with the count of products they bought
SELECT c.ContactName, COUNT(p.ProductID) CountOfProducts
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID JOIN Products p ON p.ProductID = od.ProductID
GROUP BY c.ContactName

--8. Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID, COUNT(p.ProductID) CountOfProducts
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID JOIN Products p ON p.ProductID = od.ProductID
GROUP BY c.ContactName
HAVING COUNT(p.ProductID) > 100

--9. List all of the possible ways that suppliers can ship their products.
SELECT DISTINCT sup.CompanyName 'Supplier Company Name', sh.CompanyName 'Shipping Company Name'
FROM Suppliers sup JOIN Products p ON sup.SupplierID = p.SupplierID 
JOIN [Order Details] od ON od.ProductID = p.ProductID
JOIN Orders o ON o.OrderID = od.OrderID
JOIN Shippers sh ON sh.ShipperID = o.ShipVia

--10. Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate, p.ProductName
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON o.OrderID = od.OrderID

--11. Displays pairs of employees who have the same job title.
SELECT DISTINCT e1.FirstName + ' ' + e1.LastName Employee1, e2.FirstName + ' ' + e2.LastName Employee2
FROM Employees e1, Employees e2
WHERE e1.Title = e2.Title AND e1.EmployeeID != e2.EmployeeID

--12. Display all the Managers who have more than 2 employees reporting to them.
SELECT e.FirstName + ' ' + e.LastName Manager
FROM Employees e
WHERE e.EmployeeID IN
(
SELECT ReportsTo
FROM Employees
GROUP BY ReportsTo
HAVING COUNT(ReportsTo) > 2
)

--13. Display the customers and suppliers by city. The results should have the following columns
SELECT c.City City, c.CompanyName Name, c.ContactName [Contact Name], 'Customer' [Type]
FROM Customers c
UNION
SELECT sup.City, sup.CompanyName, sup.ContactName, 'Supplier'
FROM Suppliers sup

--14. List all cities that have both Employees and Customers.
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City IN
(
SELECT e.City
FROM Employees e
)

--15. List all cities that have Customers but no Employee.
--a) Use sub-query
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN
(
SELECT e.City
FROM Employees e
)

--b) Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.EmployeeID IS NULL

--16. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) Quantity
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

--17. List all Customer Cities that have at least two customers.
--a) Use union
SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) > 2
UNION
SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) = 2

--b) Use sub-query and no union
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City IN
(
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID)>=2
)

--18. List all Customer Cities that have ordered at least two different kinds of products.
SELECT DISTINCT c.City
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.City
HAVING COUNT(od.ProductID) >= 2

--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
WITH ProductCTE
AS
(
SELECT o.CustomerID, p.ProductName, AVG(od.UnitPrice * od.Quantity) AS AveragePrice, ROW_NUMBER() OVER (ORDER BY od.Quantity DESC) AS RNK
FROM [Order Details] od JOIN Products p ON od.ProductID = p.ProductID 
JOIN Orders o ON od.OrderID = o.OrderID 
GROUP BY o.CustomerID, p.ProductName, od.Quantity
)
SELECT c.City, cte.ProductName, cte.AveragePrice, cte.RNK
FROM 
ProductCTE cte JOIN Customers c ON cte.CustomerID = c.CustomerID
WHERE cte.RNK <= 5

--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
SELECT *
FROM
(
SELECT TOP 1 e.City, COUNT(o.OrderID) TotalNumofOrders
FROM Employees e JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY e.City
ORDER BY TotalNumofOrders
) dt1
JOIN
(
SELECT TOP 1 c.City, SUM(od.Quantity) TotalQuantity
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.City
ORDER BY TotalQuantity
) dt2
ON dt1.City = dt2.City

--21. How do you remove the duplicates record of a table?
--a) We can use GROUP BY and HAVING to locate the duplicates (by using COUNT()>1) and get the unique primary key value, then drop the corresponding rows.
--b) Use CTE combined with ROW_NUMBER() function.







