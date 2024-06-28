USE Pizzaria;

USE Pizzaria;


CREATE TABLE loginn (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(30) NOT NULL
);

CREATE TABLE NovoUsuario (
    user_id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    FOREIGN KEY (user_id) REFERENCES loginn(user_id)
);

CREATE TABLE sabor_pizzas (
    sabor_id INT PRIMARY KEY,
    sabor_name VARCHAR(100) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL
);


INSERT INTO loginn (username, password, role) VALUES ('admin', 'adminpass', 'admin');

-- Adicionando os campos necessários à tabela loginn
ALTER TABLE loginn ADD username NVARCHAR(50) NOT NULL;
ALTER TABLE loginn ADD password NVARCHAR(50) NOT NULL;
ALTER TABLE loginn ADD role NVARCHAR(50) NOT NULL DEFAULT 'user';


SELECT * FROM loginn

INSERT INTO sabor_pizzas (sabor_id, sabor_name, price) VALUES
(1, 'Margherita', 25.00),
(2, 'Pepperoni', 28.00),
(3, 'Quatro Queijos', 30.00),
(4, 'Frango com Catupiry', 27.00),
(5, 'Calabresa', 26.00),
(6, 'Portuguesa', 29.00),
(7, 'Vegetariana', 24.00),
(8, 'Atum', 31.00),
(9, 'Bacon', 28.00);


UPDATE loginn
SET password = 'adminpass'
WHERE username = 'admin';



	SELECT
		constraint_name
	FROM
		information_schema.table_constraints
	WHERE
		table_name = 'pedido_recebido'
		AND constraint_type = 'FOREIGN KEY';

		ALTER TABLE talao_recibo
DROP CONSTRAINT FK__talao_rec__pedid__3B75D760;


CREATE TABLE sabor_pizzas (
    sabor_id INT IDENTITY(1,1) PRIMARY KEY,
    nome NVARCHAR(50) NOT NULL,
    preco DECIMAL(10, 2) NOT NULL
);

INSERT INTO sabor_pizzas (nome, preco) VALUES
('Margherita', 17.00),
('Pepperoni', 15.00),
('Quatro Queijos', 19.50),
('Frango com Catupiry', 17.00),
('Calabresa', 16.00),
('Portuguesa', 20.00);

UPDATE sabor_pizzas SET preco = 17.00 WHERE nome = 'Margherita';
UPDATE sabor_pizzas SET preco = 15.00 WHERE nome = 'Pepperoni';
UPDATE sabor_pizzas SET preco = 19.50 WHERE nome = 'Quatro Queijos';
UPDATE sabor_pizzas SET preco = 17.00 WHERE nome = 'Portuguesa';
UPDATE sabor_pizzas SET preco = 16.00 WHERE nome = 'Calabresa';
UPDATE sabor_pizzas SET preco = 20.00 WHERE nome = 'Frango com Catupiry';

DROP TABLE sabor_pizzas;


DELETE FROM sabor_pizzas WHERE nome = 'Atum';
DELETE FROM sabor_pizzas WHERE nome = 'Bacon';
DELETE FROM sabor_pizzas WHERE nome = 'Vegetariana';

SELECT * FROM sabor_pizzas;



CREATE TABLE pedido_recebido (
    pedido_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NOT NULL,
    sabor_id INT NOT NULL,
    quantity INT NOT NULL,
    FOREIGN KEY (user_id) REFERENCES loginn(user_id),
    FOREIGN KEY (sabor_id) REFERENCES sabor_pizzas(sabor_id)
);

CREATE TABLE loginn (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
	
);



CREATE TABLE Bebida(
bebida_id INT IDENTITY(1,1) PRIMARY KEY,
nomebev VARCHAR(50) NOT NULL,
preco DECIMAL(10,2) NOT NULL
);

INSERT INTO Bebida (nomebev,preco) VALUES
('Pepsi Cola 1.75L', 1.55),
('Fanta Laranja 1.5L',1.25),
('Coca Cola Zero 1,75L',1.95),
('7Up 1.75L',1.69),
('Guaraná Antarctica 1.5L',1.89),
('Sumol Laranja 1.75L',1.39);

UPDATE Bebida SET nomebev = 'Guaraná Antarctica 1.5L' WHERE nomebev = 'Refrigerante Guaraná Antarctica 1.5L';

SELECT * FROM Bebida;

SELECT * FROM sabor_pizzas;

SELECT * FROM loginn;





