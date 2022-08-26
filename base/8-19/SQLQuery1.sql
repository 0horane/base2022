/*CREATE FUNCTION test() returns 

DECLARE @employeenames NCHAR(100)
set @employeenames = (SELECT Employees.FirstName + ' ' + Employees.LastName FROM Employees)

SELECT * FROM (
	SELECT OrderID, YEAR(OrderDate) AS tYear, Employees.FirstName + ' ' + Employees.LastName as empname FROM ORDERS INNER JOIN Employees ON Orders.EmployeeID=Employees.EmployeeID
) S
PIVOT (
	Count(orderid)
	FOR empname in (@employeenames)

) M*/

/*

CREATE FUNCTION GetTypes(@tblname nchar) RETURNS TABLE(COLUMN_NAME nchar, DATA_TYPE nchar, NULLIS nchar)
AS
BEGIN
DECLARE @rval TABLE(COLUMN_NAME nchar, DATA_TYPE nchar, NULLIS nchar)
SET @rval = (SELECT 
        COLUMN_NAME, DATA_TYPE, IIF(IS_NULLABLE='YES', 'NULL', 'NOT NULL')
    FROM 
        INFORMATION_SCHEMA.COLUMNS
    WHERE 
        TABLE_NAME = @tblname )
RETURN(@rval);
END


DECLARE @temptbl Table(



);



*/





--	1)
/*
--A)
CREATE FUNCTION pordos(@input smallint) RETURNS smallint	
AS
BEGIN
	DECLARE @rval smallint
	SET @rval = @input * 2
	RETURN(@rval)
END
*//*

--B)
SELECT dbo.pordos(4)
--C)
SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, dbo.pordos(Products.UnitPrice) AS UnitPricePor2, UnitsInStock, dbo.pordos(Products.UnitsInStock) AS UnitsInStockPor2 , UnitsOnOrder, ReorderLevel, Discontinued FROM Products
*//*
*/

--2)
/*
--A)
CREATE FUNCTION Orders200() RETURNS TABLE
AS
RETURN(SELECT TOP 200 * FROM ORDERS)*/
/*
--B)
SELECT * FROM dbo.Orders200()
--C)
SELECT * FROM dbo.Orders200() AS tmpnm LEFT JOIN Employees ON tmpnm.EmployeeID = Employees.EmployeeID
*/

--3

CREATE FUNCTION pordos(@input1 date, @input2 date) RETURNS float	
AS
BEGIN
	DECLARE @rval date
	SET @rval = DATEDIFF(dayofyear ,@input1, @input2)
	RETURN(@rval)
END