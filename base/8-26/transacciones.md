
Una transaccione es un conjunto de operaciones de tsql que se ejecutan como bloque. Esto significa que todas las operaciones tienen que uncionar. con que haya una falla, fallan todas las operaciones. Si todo funciona, se aplica en la base de datos

##Pruebas (normas ) ACID
Atomicity Consistency Isolation Durability
A: Todas o ningua
C: Posibilidad de rollback antes de que termine
I: Tabla mutex. No puede haber una consulta a media transacción
D:

Las consultas de una sola linea UPDATE son una transacción.

###PALABRAS RESERVADAS
BEGIN TRAN
ROLLBACK TRAN
COMMIT TRAN

EJ: ```tsql

BEGIN TRANSACTION
BEGIN TRY 

Update... 
Insert...
Delete...

COMMIT TRANSACTION
END TRY

BEGIN CATCH

ROLLBACK TRANSACTION
PRINT 'Humo error!'

END CATCH

```


TENER CUIDADO: LAS TRANSACCIONES SIGUEN ACTIVAS HASTA QUE HAY UN COMMIT O ROLLBACK

No dejar toda la base de datos bloqueada por error! (bloqueo)

Los bloqueos tienden a ser solo una o upn par de filas.

##Tipos de bloqueo:
s (share) otros usuarios pueden consultar //sin editar
x (exclusive) totalmente bloqueado

##Ciclo
1) Datos se cargan en el cache
2) Se escribe un log de transacciones
3) Se espera a un commit o un rollback
4) Se escriben los datos



No relacioado: Ejecutar una sola parte del codigo seleccionandolo sql server 2018 client thing
