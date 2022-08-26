	--Te da el stock total de los productos de cada categoria segun su rango de precio. La idea era ver que en los rangos mas bajos iba a haber mas que en los altos, pero no resulto siendo tan asi
	SELECT * FROM (
		SELECT CategoryName, ROUND(UnitPrice, -1) AS PriceRange, UnitsInStock  FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
	)  S
	PIVOT (
		AVG(UnitsInStock)
		for CategoryName IN ([Beverages], [Condiments], [Confections], [Dairy Products], [Grains/Cereals], [Meat/Poultry], [Produce], [Seafood])
	) G

	--Te devuelve el dinero ganado total en cada pais cada año.
	SELECT * FROM (
		SELECT Country, YEAR(OrderDate) AS OrderYear, Quantity*UnitPrice AS Revenue FROM Customers 
		INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID 
		INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
	) S
	PIVOT(
		SUM(Revenue)
		FOR OrderYear IN ([1996], [1997], [1998])
	) N

