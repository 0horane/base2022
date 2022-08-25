--1)
/*
CREATE TRIGGER logCustomerDeletions ON Customers
FOR DELETE 
AS
INSERT INTO logHistorico VALUES(  GETDATE() , 'delete', 'usuario')
*/

/* Para probar
DELETE FROM [Order Details] WHERE OrderID IN (Select OrderID from Orders WHERE CustomerID='TOMSP')
DELETE FROM Orders WHERE CustomerID='TOMSP'
DELETE FROM Customers WHERE CustomerID = 'TOMSP'
*/

--2)
--a) Tiene la misma esructura que customers, solo que no tiene ningun registro
--b) 

/*
CREATE TRIGGER copiarCosasBorradas ON dbo.Customers
FOR DELETE
AS
INSERT INTO dbo.CustomersDeleted SELECT * FROM deleted
*/

--c)
/* Prueba
SELECT * FROM dbo.Customers LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID WHERE OrderID IS NULL

DELETE FROM Customers WHERE CustomerID = 'FISSA'


*/
--3)
/*
CREATE TRIGGER descuentoUpdater ON dbo.[Order Details]
FOR INSERT
AS
--UPDATE dbo.[Order Details] SET UnitPrice = (SELECT UnitPrice FROM dbo.Products WHERE inserted.productID = products.ProductID)
update [Order Details] set [Order Details].unitPrice = Products.unitPrice - Products.unitPrice *  [Order Details].Discount FROM [Order Details]
INNER JOIN Products  ON Products.ProductID = [Order details].ProductID 
INNER JOIN inserted ON inserted.ProductID = [Order Details].ProductID AND inserted.OrderID = [Order Details].OrderID 
WHERE Products.ProductID = inserted.ProductID AND inserted.OrderID = [Order Details].OrderID
*/

/* pRUEBAS:
DELETE FROM [Order Details] WHERE OrderID =10248 AND ProductID=13;
INSERT INTO [Order Details] (OrderID,ProductID,Quantity,Discount) VALUES (10248,13,10,0.2)
*/

--4)
/*
CREATE TRIGGER descuentoUpdater2 ON dbo.[Order Details]
FOR INSERT
AS
BEGIN
    declare @stock int
    select @stock = UnitsInStock from products
        join inserted
        on inserted.productID = products.productID
    
    
    if (@stock>=(SELECT Quantity FROM inserted))
		begin
			update [Order Details] set [Order Details].unitPrice = Products.unitPrice - Products.unitPrice *  [Order Details].Discount FROM [Order Details]
			INNER JOIN Products  ON Products.ProductID = [Order details].ProductID 
			INNER JOIN inserted ON inserted.ProductID = [Order Details].ProductID AND inserted.OrderID = [Order Details].OrderID 
			WHERE Products.ProductID = inserted.ProductID AND inserted.OrderID = [Order Details].OrderIDs
        
			UPDATE Products SET UnitsInStock = UnitsInStock - Quantity FROM Products INNER JOIN Inserted ON inserted.productID = products.productID
		end
	else
        begin
            raiserror ('No hay suficiente stock', 16, 1)
            rollback transaction
        end
END
*/
--5)
/*
CREATE TRIGGER mascuentoUpdater ON dbo.[Order Details]
FOR DELETE
AS
BEGIN
	UPDATE Products SET UnitsInStock = UnitsInStock + Quantity FROM Products INNER JOIN deleted ON deleted.productID = products.productID
END
*/

/*Prueba:
DELETE FROM [Order Details] WHERE OrderID = 10258 AND ProductID = 2
*/

--6)
/*
CREATE TRIGGER MuestraCambioNombre ON Employees
FOR UPDATE
AS
SELECT deleted.LastName AS LastNameAntiguo, inserted.LastName AS LastnameNuevo FROM deleted INNER JOIN inserted ON deleted.EmployeeID = inserted.EmployeeID 
*/

UPDATE Employees SET Employees.LastName = 'juan' WHERE EmployeeID = 1