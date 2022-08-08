--1)
SELECT * FROM (
	SELECT ProductName, [Order Details].UnitPrice, Discount FROM [Order Details] INNER JOIN Products ON [Order Details].ProductID = Products.ProductID 
) S
PIVOT(
	AVG(UnitPrice)
	for Discount in ([0.05],[0.1],[0.15],[0.2],[0.25])
) P




--2)
SELECT * FROM (
	SELECT EmployeeID, Freight, YEAR(OrderDate) as YearDate FROM ORDERS
) S
PIVOT(
	SUM(Freight)
	for [YearDate] in ([1996],[1997],[1998])
) P
