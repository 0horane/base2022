#SELECT COUNT(*) FROM usuarios WHERE `Like`=true AND Nombre="Jose";

#SELECT *, COUNT(`Like`) as likes FROM usuarios WHERE `Like`=true GROUP BY `Nombre` ORDER BY likes desc;

#SELECT AVG(Edad) FROM usuarios WHERE Pais = "Brazil";

#SELECT DISTINCT Nombre FROM usuarios WHERE Edad >= 20;

#SELECT COUNT(distinct nombre) as Cantidad from usuarios  WHERE Edad != 18 GROUP BY Nombre;

#SELECT idPublicacion FROM (SELECT *, COUNT(*) as popularity FROM usuarios  GROUP BY `idPublicacion` ORDER BY popularity DESC LIMIT 0,1)  AS tmp;