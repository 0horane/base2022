--SELECT * FROM Northwind.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' 

/*
SELECT *
FROM INFORMATION_SCHEMA.COLUMNS
--WHERE TABLE_NAME = N'ContactTitle'
*/
/*
CREATE PROCEDURE spMasemps
AS
BEGIN
SELECT TOP(5) MAX(FirstName)+' '+MAX(LastName) AS Nombre, COUNT(OrderID) AS CantOrdenes 
FROM Employees 
INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID 
GROUP BY Employees.EmployeeID
ORDER BY CantOrdenes DESC
END

*/
--exec spMasemps

--2)

/*
CREATE PROCEDURE spProdsOfCat
@incatname nvarchar(15)
AS
BEGIN
SELECT Products.* 
FROM Products 
INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID 
WHERE CategoryName = @incatname
END
*/
--exec spProdsOfCat 'Condiments'

--3)
/*
CREATE PROCEDURE sp3queries
@TerritoryID1 int,
@TerritoryID2 int,
@TerritoryID3 int
AS
BEGIN
UPDATE Territories SET TerritoryDescription = 'Houston' WHERE TerritoryID = @TerritoryID1;
DELETE FROM Territories WHERE TerritoryID = @TerritoryID2;
INSERT INTO Territories VALUES(@TerritoryID3,'',1);
END
*/
--exec sp3queries 02184,29202,02377

--4)
--exec spCountShipperRegions

/*
ALTER PROCEDURE spCountShipperRegions
AS
BEGIN
SELECT * FROM (
	SELECT ProductID, CategoryName, CompanyName FROM Products 
	INNER JOIN Categories ON Categories.CategoryID= Products.CategoryID
	INNER JOIN Suppliers ON Suppliers.SupplierID= Products.SupplierID
) S
PIVOT(
	COUNT(ProductID)
	for CategoryName IN ([Beverages], [Condiments], [Confections], [Diary Products], [Grains/Cereals], [Meat/Poultry], [Produce], [Seafood])
) G
END

*/
--5)
/*
CREATE PROCEDURE spFact
@inputnum int,
@outputnum int OUTPUT
AS
BEGIN
SELECT @outputnum=dbo.FACTORIAL(@inputnum)
END
*/
DECLARE @temp int;
exec spFact 5, @outputnum=@temp OUTPUT;
print @temp;