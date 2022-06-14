
--EXERC�CIO 01 ESCOLHER 04 COMANDOS E ESPECIFIC�-LOS



--COMANDO 01 - CRIAR UM BANCO DE DADOS CHAMADO EXERC�CIO SQL

CREATE DATABASE EXERCICIO_SQL
GO

USE EXERCICIO_SQL
GO


--COMANDO 02 - CRIA UMA TABELA CHAMADA AGENDA COM OS ATRIBUTOS NOME, TELEFONE E ENDERE�O
--SEUS TIPOS E A QUANTIDADE DE POSI��ES QUE CADA ATRIBUTO VAI POSSUIR.

CREATE TABLE AGENDA (NOME VARCHAR(36), TELEFONE VARCHAR(20), ENDERECO VARCHAR(200))
GO



--COMANDO 03 - INSERE NA TABELA AGENDA OS SEGUINTES VALORES: NOMES, NO ATRIBUTO NOME; TELEFONES, NO ATRIBUTO TELEFONE
--E ENDERE�OS NO ATRIBUTO ENDERE�O
INSERT INTO AGENDA VALUES ('Katrina Bennet Litt', '(99) 6 0666-0666','RUA DA FOI�E, AVENIDA 999, CASA 999, ATLANTIC CITY'),
('Samantha Whilhams Wheeler', '(66) 6 6333-6333','CONDOM�NIO LUZ SE FER,APARTAMENTO 333, PARADOX CITY'),
('Virgulino Cangaceiro Silva', '(38) 945380-1240', 'RUA DA PEIXEIRA, ESTRADA DA FACA '),
('Calombrose Atrofias Rim ', '(99) 63693-9689', 'AVENIDA OSTROPOROSE, APARTAMENTO 13 '),
('Teobaldo Junior Santos', '(38) 945380-1240', 'MORRO DA GALINHA, BAIRRO 17, CASA 43, LOTE 30, BECO3, ESQUINA 7 ')

GO



--COMANDO 04 - IMPRIME TODOS OS ATRIBUTOS CONTIDOS NA TABELA AGENDA
SP_COLUMNS AGENDA
GO

SELECT * FROM AGENDA
GO


--COMANDO 05 - IMPRIME A QUANTIDADE DE PESSOAS CADASTRADAS
SELECT COUNT(*) AS 'CONTAGEM TOTAL DE PESSOAS' FROM AGENDA
GO






















