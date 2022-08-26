
CREATE FUNCTION FACTORIAL(
@input int
) RETURNS float --Hay que usar float porque todos los otros tipos son muy chicos para los factoriales
AS
BEGIN
	DECLARE @counter int = @input
	DECLARE @resultado float = @input
	/* Funciona, pero hay un limite de recursion de 32
	SET @resultado = @input - 1
	RETURN ( IIF(@input=0,
					0, 
					IIF(@input=1,
						1,
						@input * dbo.FACTORIAL(@resultado) ) ))
	*/
	WHILE @counter > 1
	BEGIN
		SET @counter = @counter - 1
		SET @resultado = @resultado * @counter
	END
	RETURN(@resultado)
END

--b)
SELECT dbo.FACTORIAL(Quantity) FROM [Order Details] 
--c)
SELECT dbo.FACTORIAL(ReorderLevel) FROM Products
--2)

CREATE FUNCTION FINDEPRODUCTS() RETURNS TABLE
AS
RETURN SELECT TOP(30) * FROM PRODUCTS ORDER BY ProductID DESC


SELECT * FROM dbo.FINDEPRODUCTS() AS FINDEPRODUCTS  RIGHT JOIN Categories ON FINDEPRODUCTS.CategoryID = Categories.CategoryID

--3)

CREATE FUNCTION DIFDIAS(@dia1 date, @dia2 date) RETURNS FLOAT
AS
BEGIN
	RETURN( CONVERT(float, DATEDIFF(day, @dia1, @dia2) ))
END

SELECT dbo.DIFDIAS(ShippedDate, RequiredDate) FROM Orders

SELECT COUNT(OrderID) AS DelayedOrders FROM Orders WHERE dbo.DIFDIAS(ShippedDate, RequiredDate) < 0