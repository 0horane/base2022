 use PlantAndHealth
/*
1) MOSTRAR tabla vendedores
2) MOSTRAR tabla clientes
3) ¿cuántos clientes  hay?
4 ) ¿Cuántos vendedores hay?
5)  tipos distintos de capacitación del vendedor?
6) promedios de horas de capacitación del  vendedor?

8) MOSTRAR tabla articulos
9) tipos distintos de familia artículos?
10) precio unitario  promedio según cada familia de artículos?

11)¿Cuántos tipos distintos de familia artículos?
12)utilidad promedio de cada familia de artículos?
13) MOSTRAR tabla ventas
14) MOSTRAR  5   id_vendedores con mas ventas
15) MOSTRAR  5   id_CLIENTE con mas compras
16) MOSTRAR  5   sucursal_id con mas ventas
17) MOSTRAR tabla detallesventas
18) cantidad total de registros de latabla detallesventas?
19)total de venta( precio_unitario *cantidad ) del codigo producto PLT0029  detallesventas? es igual a la columna Total?
20) mostrar unidas comuna, provincia y region
21) mostrar la tabla sucursal
22)  mostrar las top5 de comunas con mas sucursal



*/

--1)
--SELECT * FROM VENDEDORES
--Da una lista de vendedores con nombre, apellido, la capacitacion que tiene, y cuantas horas de capacitacion tienen
--
--2)
--SELECT * FROM CLIENTES
-- Da una lista de clientes con informacion personal 
--
--3)
--SELECT count(ID_CLIENTE) FROM CLIENTES
--Hay 1000 clientes
--
--4)
--SELECT count(ID_VENDEDOR) FROM VENDEDORES
--hay 50 vendedores
--
--5)
--SELECT DISTINCT [TIPO_ CAPACITACION] FROM VENDEDORES
-- Hay 5, describe el modo en el que fueron capcitados
--
--6)
--SELECT AVG(HORAS_CAPACITACION) FROM VENDEDORES
-- 33
--
--8)
--SELECT * FROM ARTICULOS
-- tiene los articulos, en codigo, nombre, familia, y percios
--
--9)
--SELECT count(DISTINCT [FAMILIA]) FROM ARTICULOS
--34
--
--10)
--SELECT AVG(PRECIO_UNITARIO) FROM ARTICULOS GROUP BY FAMILIA
--Entre 6000 y 25000. La mayoria son de una solo
--
--11) 
--SELECT DISTINCT [FAMILIA] FROM ARTICULOS
-- y bueno es a ista de familias que queres
--
--12)
--?????????
--SELECT FAMILIA, AVG(PRECIO_UNITARIO-COSTO_UNITARIO) froM ARTICULOS GROUP BY FAMILIA

--13)
--SELECT * FROM VENTAS
--habla de las ventas, entre quienes fue, donde fue, cuando

--14)
--SELECT TOP 5 ID_VENDEDOR,COUNT(DOCUMENTO) as cuantos FROM VENTAS GROUP BY ID_VENDEDOR ORDER BY cuantos desc
--
--
--15_
--SELECT TOP 5 ID_CLIENTE,COUNT(DOCUMENTO) as cuantos FROM VENTAS GROUP BY ID_CLIENTE ORDER BY cuantos desc
--
--16)
--SELECT TOP 5 SUCURSAL_ID,COUNT(DOCUMENTO) as cuantos FROM VENTAS GROUP BY SUCURSAL_ID ORDER BY cuantos desc
--
--
--17)
--SELECT * FROM DETALLE_VENTA
--Contiene el producto que se compta en cada venta por que precio y la cantidad. Tiene info redundante

--18
--SELECT count(DOCUMENTO) from DETALLE_VENTA
--10001
--
--19)
--SELECT precio_unitario * cantidad as totaldeventa, total FROM DETALLE_VENTA WHERE CODIGO_PRODUCTO = 'PLT0029'
--si, como dije antes, es redundante

--20)
--SELECT * FROM COMUNA INNER JOIN Provincia ON COMUNA.PROVINCIA_ID = PROVINCIA.PROVINCIA_ID INNER JOIN REGION ON REGION.REGION_ID = PROVINCIA.REGION_ID

--21)
--sElEcT * fRoM sUcUrSaL
--y son las sucursales 

--22)
--SELECT TOP 5 SUCURSAL.COMUNA_ID, MAX(COMUNA_NOMBRE) FROM COMUNA INNER JOIN SUCURSAL ON COMUNA.COMUNA_ID =  SUCURSAL.COMUNA_ID GROUP BY SUCURSAL.COMUNA_ID order by COUNT(SUCURSAL.COMUNA_ID)
--todas tienen la misma cantiad: 1

