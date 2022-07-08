```sql
CREATE DATABASE customers;
CREATE TABLE Customers(
	CustomerID int,
	Country varchar(30)
);

```


### PIVOT
```sql
SELECT 


FROM (
    SELECT 
    TipoDocumento, 
    Documento, 
    Monto, 
    YEAR(Fecha) AS Fecha 
    FROM Ventas
) AS Ventas
PIVOT 
(
AVG(Monto)
For Fecha IN ([2016],[2017],[2018],[2019],[2020])
) AS PIVOTE






--SELECT Pais, Cat, Total FROM temppivot 
--UNPIVOT (Total for Cat in (bebida, fast, comida, pescadao, leche)) as Tabla


SELECT * FROM (
SELECT OrderID, Quantity,ProductName FROM OrderDetails INNER JOIN PRODUCTS ON OrderDetails.ProductID = Products.ProductID
) AS Orders
PIVOT (
SUM(Quantity) FOR ProductName IN () 
) AS PIVOTE

```