CREATE TABLE Product (
	id INT PRIMARY KEY UNIQUE NOT NULL,
	name VARCHAR (255) NOT NULL
);
CREATE TABLE Category (
	id INT PRIMARY KEY UNIQUE NOT NULL,
	name VARCHAR (255) NOT NULL
);
CREATE TABLE Relationship(
	id_product INT NOT NULL,
	id_category INT NOT NULL
);
INSERT INTO Product VALUES (1, 'Перчатки'), (2, 'Шапка'), (3, 'Фанта'), (4, 'Молоко'), (5, 'Макароны'), (6, 'Лыжи');
INSERT INTO Category VALUES (1, 'Еда'), (2, 'Напитки'), (3, 'Одежда'), (4, 'Игрушки');
INSERT INTO Relationship VALUES (1, 3), (2, 3), (3, 1), (3, 2), (4, 1), (4, 2), (5, 1);
SELECT Product.name, Category.name FROM Product
	LEFT JOIN Relationship ON Product.id = Relationship.id_product
	LEFT JOIN Category ON Category.id = Relationship.id_category;