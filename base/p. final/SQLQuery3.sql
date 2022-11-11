use DWpinton;
--INSERT INTO D_PRODUCTS ([Product Name], [Product Price]) SELECT DISTINCT [Item Name], [Product Price] FROM tableName
SELECT [order number], [ORDER DATE], SUBSTRING([order date], 1,2)+'/'+SUBSTRING([order date], 4,2) +SUBSTRING([order date], 6,11), [total products] FROM tableName
