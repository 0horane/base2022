/*
SELECT Orders.ShipCity, Employees.FirstName 
FROM Orders, Employees 
WHERE Orders.EmployeeID = Employees.EmployeeID
*/
/*
SELECT Orders.ShipCity, Employees.FirstName 
FROM Orders INNER JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID
*/

--1)
--a)
/*
CREATE VIEW viewProducts AS
SELECT ProductID, ProductName, UnitPrice  FROM Products
*/
--b)
/*
ALTER VIEW viewProducts AS
SELECT ProductID, ProductName, UnitPrice, CategoryID  FROM Products
*/
/*
SELECT ProductName, CategoryName FROM viewProducts INNER JOIN Categories ON viewProducts.CategoryID= Categories.CategoryID WHERE  Categories.CategoryName='Beverages'
*/

--2)

/*CREATE VIEW inventarios  AS
SELECT CategoryName, COUNT(ProductID) AS count FROM Categories INNER JOIN viewProducts ON viewProducts.CategoryID = Categories.CategoryID GROUP BY Categories.CategoryName
*/
--select * from inventarios

--3)
/*
CREATE VIEW  view3  AS
SELECT CategoryName, AVG(UnitPrice) AS avgprice FROM Categories INNER JOIN viewProducts ON viewProducts.CategoryID = Categories.CategoryID WHERE CategoryName = 'Produce' OR CategoryName='Confections' GROUP BY Categories.CategoryName 
*/
--select * from view3

--4
/*
CREATE VIEW  view4  AS
SELECT * FROM Customers WHERE CompanyName LIKE 'B%' AND Country='UK'
*/
--SELECT * from view4

--5
/*
CREATE VIEW  view5  AS
SELECT * FROM Products WHERE UnitPrice BETWEEN 50 AND 200
*/
--Select * from view5

--6)
/*
CREATE VIEW  view6  AS
SELECT Orders.* FROM Orders INNER JOIN Employees On Orders.EmployeeID = Employees.EmployeeID WHERE FirstName+' '+LastName IN ('Andrew Fuller','Nancy Davolio','Robert King')
*/
--SELECT * FROM view6

--7)
/*
CREATE VIEW  view7  AS
SELECT TOP ((SELECT COUNT(OrderID) FROM [Order Details])/4) * FROM [Order Details]
*/
SELECT * FROM [Order Details]


