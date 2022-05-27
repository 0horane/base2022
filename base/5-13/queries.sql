SELECT COUNT(DISTINCT(cargo)) FROM `miembros`;
SELECT * FROM `miembros` WHERE salario = (SELECT MAX(salario) from miembros);
SELECT * FROM `miembros` WHERE salario = (SELECT MIN(salario) from miembros);
SELECT AVG(salario) FROM `miembros`;
SELECT * FROM `miembros` WHERE edad = (SELECT MAX(edad) from miembros);
SELECT * FROM `miembros` ORDER BY nombre ASC