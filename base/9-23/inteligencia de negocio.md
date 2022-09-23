###Business intelligence
= inteligencia de negocio = intligenca empresarial. 
EL la habilidad de transformar datos en información que nos sirva para tomar mejores deciciones.

###Datawarehouse
almacen de datos. Requiere gestion de alta cantidad de almacenamiento. Se usa para data mining (buscar tendencias e informacion en los datos)

#####Tipos:
- de empresas (EDW): centalizados, se puede segun el tema
- Operacionales (ODS) en tiempo real. sirve para cosas cotidianas  como informes
- /??

###ETL
extracion, transformacion, y carga (loading)
###Data Marts ⊂ DW
- Dont mess with my data
- Keep it simple for the user
- Small problems are easier to solve.


###marts vs warehouse
Se enfoca en un solo tema   |   toda la empresa 

< 100 GB                    | 100GB <
de igual normalizacion      | sin normalizacion

###modelos datawarehouse
- Inmon
Warehouse es la fuente de datos para los marts.
- Kimball
Varois datamarts conglomerados forman al warehouse

---------
luego los datos se usan para hacer un reporting o un datamine o un analisis  

la definicion de datawarehouse varia, puede ser solo el almacen final o incluir al conjunto de sistemas de herrmainetas de analisis y extraccion de datos.  
  
El datawarehouse no es una base de dato transaccional. No est diseñado para escribir, borrar, reemplazar, etc. datos. Principalmente para la lecture.   
  
Usa conceptos como clientes, no importa l anormalización, muesra información consolidada y no detallada, 


####Modelo de estrella
Modelo en el cual hay una tabla de hechos en el medio unida a otras de dimesniones que une a data marts para generar una data warehouse kimball. 

Hechos: eventos **medidos**: asistencias, calificaciones
Dimensiones: Que, cuando, donde,como, donde...: Estudiantes, escuelas, Maestros, Materias, Examenes

Hechos: 
- todo lo que se pueda medir. 
- Tablas muy grandes, muchos registos
- Compuesta porclaves foraneas de las tablas de dimension



Dimensiones: 
- no se pueden medir sino quizas enumerar 
- Tablas menores, pocos registros
- Unidas a tabla hechos por id

#####ventajas
- no normalizado, mas facil de armar
- Reglas de normalizacion se relaja en el diseño y ...
- La logica de coneccionno esta normalizado y por lo tantoes mas intuitiva
- Mejor performance x no normalizacion
- Mejor performance x estrella
######desventajas
- No hay buen resguardo de errores debido a desnormalizacion
- El modelo estrella solo permite relaciones uno a muchos

####Data mining 
utiliza grandes bases de datos para obtener insights sobre comportamientos que se repiten consistentemente en la base de datos.  
Para esto los datos deben ser limpiados y distribuidos uniformemente.  
Los insights se pueden usar para alcanzar objetivos en las organizaciones.


#VISTAS
- tablas virtuales
- permiten ocultar informacion y solo dar acceso a algunos datos
- simplifica la dministracion de permisos de ususario
- mejoa el rendimiento para no repetir queries con join

```tsql
CREATE VIEW view_name AS
SELECT .... WHERE...
```

exec SP_HELPTEXT: de que tabla viene una vista.

si pones encryption no permite que el usuario sepa de que tabla viene
```tsql
CREATE VIEW view_name WITH ENCRYPTION AS
SELECT .... WHERE...
```

## Indices en SQL Server
se usa para poder recuperar datos de la base de datos más rápidamente. Mejora el rendimiento para las bases enormes. Es una tabla de busqueda rapida para los datos que tienen mayor recuencia.

