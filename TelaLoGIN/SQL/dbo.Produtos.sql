CREATE TABLE Produtos
(id_produto INT PRIMARY KEY IDENTITY(1,1),
 nome VARCHAR (255) NOT NULL,
 nome_categoria VARCHAR (255) NOT NULL,
 descricaoproduto VARCHAR (255) NOT NULL,
 nome_fornecedor VARCHAR (255) NOT NULL,
 quantidade INT NOT NULL,
 valor MONEY NOT NULL,
 valorbruto MONEY NOT NULL,
);