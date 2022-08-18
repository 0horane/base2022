
INSERT INTO Customers VALUES(1,'Alfreds Futterkiste', 'Maria Anders', 'Obere Str. 57', 'Berlin', '122909', 'Germany');
INSERT INTO Customers VALUES(2,'Ana trujillo Emparedados y helados', 'Ana Trujillo', 'Avda. de la Constitución', 'México D.F.', '05021', 'Mexico');
INSERT INTO Customers VALUES(3,'Antonio Moreno Taquería', 'Antonio Moreno', 'Mataderos 2312', 'México D.F.', '05023', 'Mexico');
INSERT INTO Customers VALUES(4,'Around the Horn', 'Thomas Hardy', '120 Hanover Sq.', 'London', 'WA1 1DP', 'UK');
INSERT INTO Customers VALUES(5,'Berglunds snabbköp', 'Christina Berglund', 'Berguvsväven 8', 'Luleå', '5-968 22', 'Sweden');
INSERT INTO Customers VALUES(6,'Blauer See Delikatessen', 'Hanna Moos', 'Forsterstr. 57', 'Mannheim', '68306', 'Germany');
INSERT INTO Customers VALUES(7,'Blondel père et fils', 'Frédérique Citeaux', '24, place Kléber', 'Strasbourg', '67000', 'France');
INSERT INTO Customers VALUES(8,'Bólido Comidas preparadas', 'Martín Sommer', 'C/ Araquil, 67', 'Madrid', '28023', 'Spain');

INSERT INTO Shippers VALUES(1, 'Speedy Express', '(503) 555-9831');
INSERT INTO Shippers VALUES(2, 'United Package', '(503) 555-3199');
INSERT INTO Shippers VALUES(3, 'Federal Shipping', '(503) 555-9931');



INSERT INTO Orders VALUES(10248,1,5,'1996-7-4', 3);
INSERT INTO Orders VALUES(10249,1,6,'1996-7-5', 1);
INSERT INTO Orders VALUES(10250,3,4,'1996-7-8', 2);
INSERT INTO Orders VALUES(10251,8,3,'1996-7-8', 1);
INSERT INTO Orders VALUES(10252,4,4,'1996-7-9', 2);
INSERT INTO Orders VALUES(10253,5,3,'1996-7-10', 2);
INSERT INTO Orders VALUES(10254,4,5,'1996-7-11', 2);
INSERT INTO Orders VALUES(10255,8,9,'1996-7-12', 3);


INSERT INTO Products VALUES(1, 'Chais', 1,1,'10 boxes x 20 bags',18);
INSERT INTO Products VALUES(2, 'Chang', 1,1,'24 - 12 oz bottles',19);
INSERT INTO Products VALUES(3, 'Aniseed Syrup', 1,2,'12 - 550 ml bottles',10);
INSERT INTO Products VALUES(4, 'Chef Anton''s Cajun Seasoning', 2,2,'46 - 6 oz jars',22);
INSERT INTO Products VALUES(5, 'Chef Anton''s Gumbo Mix', 2,2,'36 boxes',21.35);
INSERT INTO Products VALUES(6, 'Grandma''s Bysenberry Spread', 3,2,'12 - 8 oz jars',25);
INSERT INTO Products VALUES(7, 'Uncle Bob''s Organic Dried Pears', 3,7,'12 - 1 lb pkgs.',30);

INSERT INTO OrderDetails VALUES(1,10248,1,12);
INSERT INTO OrderDetails VALUES(2,10248,2,10);
INSERT INTO OrderDetails VALUES(3,10248,2,5);
INSERT INTO OrderDetails VALUES(4,10249,2,9);
INSERT INTO OrderDetails VALUES(5,10249,4,40);
INSERT INTO OrderDetails VALUES(6,10250,5,10);
INSERT INTO OrderDetails VALUES(7,10250,5,35);
INSERT INTO OrderDetails VALUES(8,10250,7,15);