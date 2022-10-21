--------------1---------------
/*
use NorthwindTurnoTarde;
set transaction isolation level read committed;
Begin tran unouno
insert into employees (LastName, Firstname) values('roca','juan');
COMMIT TRAN;
*/


use NorthwindTurnoTarde;
set transaction isolation level read committed;
Begin tran tres
UPDATE customers SET [Address] = 'pase colon' WHERE CustomerID='ALFKI';
COMMIT TRAN;


--------------2---------------
/*
use NorthwindTurnoTarde;
set transaction isolation level read committed;
Begin tran unodos
	Select * From employees ;
	waitfor delay '00:00:12'
	Select * From employees ;
COMMIT TRAN;
*/

use NorthwindTurnoTarde;
set transaction isolation level read committed;
Begin tran uno
	Select * From customers ;
	waitfor delay '00:00:12'
	Select * From customers ;
COMMIT TRAN;
/*
1)Recrear una Lectura Fantasma, para eso  van a programar en dos ventanas, que simulan dos usuarios.
ver el ejemplo en la pdf de hoja 37 figura numero 2.5
para la tabla  Employees en el rango  2 y 20, 

inserta en la tabla employees (LastName,FirstName) juan roca



3)Recrear una No Reproducibilidad, para eso  van a programar en dos ventanas, que simulan dos usuarios.
ver el ejemplo en la pdf de hoja 36 figura numero 2.4
el udpate tiene esa forma: un update al campo address a ejemplo ‘paseo colon’’ y al custemerID=’alfki’.
Elegir un rango a su conveniencia

 2)Recrear una Lectura Sucia, para eso  van a programar en dos ventanas, que simulan dos usuarios.
ver el ejemplo en la pdf de hoja 35 figura numero 2.3
 el udpate tiene esa forma:  un update al campo address a ejemplo ‘mitre’ y al custemerID=’alfki’.

 4)Recrear el problema de actualizacion perdida, para eso  van a programar en dos ventanas, que simulan dos usuarios.
ver el ejemplo en la pdf de hoja 34 figura numero 2.2
Para eso van actualizar el precio(unitprice) del producto id=1.
En una ventana unitprice=unitprice + 2 , y en la otra unitprice=unitprice +4 ,



*/