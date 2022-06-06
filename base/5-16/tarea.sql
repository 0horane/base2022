--a
SELECT * FROM alumnos WHERE direccion = "La Matanza";
--b
SELECT * FROM alumnos WHERE apellido REGEXP "^[a-gA-G].*";
--c
SELECT * FROM alumnos WHERE promedio = (SELECT MIN(promedio) FROM alumnos);
--d
SELECT apellido FROM alumnos ORDER BY apellido ASC;
--e
SELECT * FROM alumnos WHERE edad = (SELECT MAX(edad) FROM alumnos);
--f
SELECT * FROM alumnos WHERE apellido REGEXP "^[h-zH-Z].*"; 
--g
SELECT direccion FROM alumnos;
--h
SELECT mail, telefono FROM alumnos;
--i
SELECT * FROM alumnos WHERE num_previas = (SELECT MAX(num_previas) FROM alumnos);
