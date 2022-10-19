
DROP TABLE TB_PRODUTO;



CREATE TABLE TB_PRODUTO
(
		ID INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
        NOME VARCHAR(100) NOT NULL,
        CODIGO_BARRAS VARCHAR(100) NOT NULL,
        PRECO DECIMAL(10,2) NOT NULL,
        ID_CATEGORIA INT NOT NULL,
        DATA_CADASTRO TIMESTAMP NOT NULL,
        DATA_ALTERACAO TIMESTAMP
);