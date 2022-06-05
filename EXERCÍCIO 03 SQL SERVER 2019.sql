CREATE DATABASE EXERCICIO3_SQL
GO

USE EXERCICIO3_SQL
GO

CREATE TABLE PRODUTOS (DESCRICAO VARCHAR(250), DIMENSAO VARCHAR(20), QUANTIDADE INT, VALORUNITARIO MONEY)
GO

INSERT INTO PRODUTOS VALUES ('kljdjsd kjdlkjdfks kjsakljdkslajd kjsaldjaslkj', '50 x 60 x 30', 36, 369.36),
('kljdjsd kjdlkjdfks kjsakljdkslajd kjsaldjaslkj', '50 x 60 x 30', 36, 369.36),
('kljdjsd kjdlkjdfks kjsakljdkslajd kjsaldjaslkj', '50 x 60 x 30', 36, 369.36),
('kljdjsd kjdlkjdfks kjsakljdkslajd kjsaldjaslkj', '50 x 60 x 30', 36, 369.36),
('kljdjsd kjdlkjdfks kjsakljdkslajd kjsaldjaslkj', '50 x 60 x 30', 36, 369.36)
GO

SP_COLUMNS PRODUTOS
GO
SELECT * FROM PRODUTOS
GO

SELECT CONCAT (DESCRICAO, ' TEM ', QUANTIDADE, ' EM ESTOQUE COM UM VALOR UNITÁRIO DE R$ ', VALORUNITARIO, ' E O VALOR TOTAL DOS PRODUTOS É R$ ', (QUANTIDADE * VALORUNITARIO)) FROM PRODUTOS
GO