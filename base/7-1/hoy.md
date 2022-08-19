## ACTORES:

#### Administrador
mantener, hacer backups, manejar permisos

#### DIseniador
diseñar,  colocar base de datos

#### Diseñador de aplicaciones
crea program que usan la base de datos. Utilizan sus interfaces 

##Ciclo de vida
- Analisis ( se plantean requerimientos y objetivos segun necesidades)
- Diseño (de hace el diseño conceptual, logico, y fisicom, detectando entidades, relaciones, cardinalidad, tablas )
- Implementacion (se arma, en premise (en local) o en la nube la base de datos, y se implementa alguna manera de ingresar info. Tambien se pueden hacer bases no relacionales, niveles diferentes de privacidad, etc)
- Captura (los usuarios finales usan constantemente el sistema. Se usa un DBMS (data base management system) para administrar cosas)


## SGBD o RDBMS 
(Sistema de gestion de bases de datos/Relacional database management system)

usos:
- Permite almacenar, acceder y actualizardatos
- proporcionar mecanismos de seguridad

## Complonentes
####procesador de consultas
transforma las consoltas en isntrucciones de maquina
####gestor de base de datos
interface con programs de aplicacion y usuarios. 
####gestor de archivos
####almacena las bases de datos y archivos en el disco.

####prepreocesador LMD

#### diccionario de datos
contine la estructura de la base ed datos y lo mantiene



##MYSQL VS SQLSERVR
mysql codigo abierto. se usa mucho en la web para pequeños y medianos proyectos. 

sqlserver pago y codigo cerrado. se usa para cosas mas grandes. limitaciones de ,e,oria, cpu, (mas pesado) se usa para empresarial y mucho .net. Desde 2017 se ofrece para linux

####Similitudes
muy escalables
mucha performance
drivers para lenguajes populares

#### diferencias
sintaxis algo diferentes
motores de almacenamiento : mysql tiene muchos, server solo 1
(innoDB es mas estable mientras que MYI... es mas rapido)
costo, libre vs pago

#### cual elejir?
sql para cosas web y cosas independientes. Server para entornos empresariales y desarrollo .net. 


## Normalizacion de bases de datos:

 es el proceso de reformar una base de datos para mayor eficiencia, reducir el sepacio, eliminar redundancia, y ordenar datos
 
 ####Primera froma normal
 1) Se debe eliminar los grupos repetitivos de las tablas
 2) Crear tablas para cada grupo de datos relacionado
 3) identificar cada grupo de datos relacionados con una llve rimaria
 
 Al final de la etapa lo siguiente se debe cumplir.:
  - Todos los atributos son atomicos
  - La tabla tiene una llave primaria unica
  - No debe existir variacion en el numero de las columnas
  - Los capos deben identificarse por la clave
  - Si se cambia el orden de los columnas o filas nada debe cambiar
  
 
   ####Segunda froma normal
   Todas las dependencias parciales se deben poner en sus propias tablas.
   
   todas las columnas deben depender de la llave primaria.
   
   
   
   
    ####Tercera froma normal