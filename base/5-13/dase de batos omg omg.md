## Usuarios y administradores de bases de datos

Las personas que trabajan en una base de datos se pueden catalogar como usuarios de una base de datos o como administradores de una base de datos.

#### Usuarios de bases de datos e interfaces de usuarios

Hay 4 tiposs diferentes de usuarios de un sistema de base de datos.

1- Usuarios Normales:
  Son usuarios no sofisticados que interactuan con el sistema mediante la invocacion de alguno de los programas de aplicacion. Por ejemplo: 
  * Un cajero bancario que necesita transferir 50 dolares de la cuenta a la cuenta b. Invoca un programa llamado transferir
2- Programadores de aplicaciones:
  Los programadores pueden elejir entre muchas herramientas para desarrollar interfaces de usuarios. Las herramientas de desarrollo rapido de aplicaciones (D.R.A). Permiten al programador construir formularios e informes sin escribir un programa
3- Usuarios sofisticados:
  Interactuan con el sistema sin programas escritos. En su lugar, ellos forman sus consultas en un lenguaje de consultas de base de datos. Cada una de estas consultas se envia al procesador de consultas cuya función es transformar instrucciones LMD a instrucciones que el gestor de almacenamiento entienda. Los analistas que envian las consultas para explorar los datos entran en esta categoría
4- Usuarios especializados: 
  Estos usuarios escriben aplicaciones de base de datos especializadas y personalizadas que no son adecuadas en el marco de procesamiento de datos tradicionales. Entre estas aplicaciones están los sistemas de diseño asistidos por computadoras, sistemas de bases de conocimiento, y sistemas expertos, sistemas que almacenan los datos con tipos de datos complejos. Ejemplos:
  * Datos graficos
  * Datos de audio
  * etc
  * Sistemas de modelado de entorno (como de videojuegos)
  
  
Ejs: 1) usuario de cajero automatico
2) programadores de aplicaciones
3) Usuarios sofisticados
4) Usuarios especializas
#### Administradores de la base de datos

Las funciones del ABD constituyen las siguientes

1- **Definicion de sistema:**
  El ADB crea el sistema original, escribe un conjunto de instrucciones que van a describir la base de datos.
2- **Definicion de la estructura y el método de acceso**
3- **modificacion del esquema de la organizacion física.** 
  Los ADB realizan cambios en el esquema y en la organizacion para reflejar las necesidades cambiantes de la organizacion o para alterar la organizacion fisica 
4- Concesión de autorizacion para el acceso a los datos.
  La conceción de diferentes tipoa de autorizacion permite al administrador de datos determinar a que partes de la base de datos puede acceder cada usuario. Esta informacion de la autorizacion se mantiene en una estructura del sistema especial que el sistema de DB consulta cuando se intenta el acceso a los datos del sistema
5- Mantenimiento rutinario: 
  Algunos ejemplos de actividadesrutinarias del mantenimiento del ADB son:
  * Copia de seguridad periódica de la DB sobre servidores remotos para prevenir la perdida de datos en caso de desastres
  * Asegurarse que halla suficiente espacio libre eb el disco para las operaciones normales y aumentar el espacio en el disco segun las necesidades
  * Supervision de los trabajos que se ejecuten en la base de datos y asegurarse que el rendimiento no se degrada por tareas muy costosas iniciadas por algunos usuarios