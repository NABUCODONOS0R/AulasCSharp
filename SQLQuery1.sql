CREATE DATABASE AULAINTRODUCAO /*SEMPRE EM CAPSLOCK*/
GO /*EM VEZ DE PONTO E V�RGULA, URLIZA-SE A CL�USULA GO*/
/*DROP DATABASE E O NOME DO BANCO DE DADOS E DEPOIS GO PARA EXCLUIR*/


USE AULAINTRODUCAO
GO
/*PARA FAZER O USO DO BANCO DE DADOS CRIADO*/


--O C�DIGO ABAIXO CRIA UMA TABELA CHAMADA PESSOA COM OS ATRIBUTOS PASSADOS

CREATE TABLE PESSOA(NOME VARCHAR(100), IDADE INT, SEXO CHAR(1), TELEFONE VARCHAR(20), ENDERECO VARCHAR(200))
GO



SELECT * FROM INFORMATION_SCHEMA.TABLES
GO
/*COMANDO ACIMA � PARA MOSTRAR AS TABELAS*/




SELECT * FROM INFORMATION_SCHEMA.COLUMNS
GO
/*O COMANDO ACIMA MOSTRA OS ATRIBUTOS CONTIDOS NA TABELA*/


SP_COLUMNS PESSOA
GO
/*A MESMA COISA DO COMANDO ANTERIOR*/




SP_HELP PESSOA
GO
/*INFORMA��ES SOBRE A TABELA PESSOA*/





/*O COMANDO ABAIXO DIZ: INSIRA NA MINHA TABELA PESSOA OS VALORES, NOME, IDADE, SEXO E ENDERE�O*/

INSERT INTO PESSOA VALUES('Marcos Scott Specter', 36, 'M', '(66) 96660-6660', 'BERVELY HELLS, RUA 666 - AVENIDA DO ABISMO - CASA 999')
GO



--O COMANDO ABAIXO DIZ: SELECIONE TUDO DA MINHA TABELA PESSOA � RECOMENDADO EVITAR O C�DIGO ABAIXO

SELECT * FROM PESSOA
GO



--O COMANDO ABAIXO DIZ ISIRA NA MINHA TABELA PESSOA NOS ATRIBUTOS NOME E SEXO OS VALORES ALEX...

INSERT INTO PESSOA (NOME, SEXO) VALUES('Alex Zane', 'M')
GO

INSERT INTO PESSOA VALUES ('Katrina Bennet Litt', 27, 'F', '(99) 6 0666-0666', 'RUA DA FOI�E, AVENIDA 999, CASA 666, ATLANTIC CITY'),
('Samantha Whilhams Wheeler', 25, 'F', '(333) 6 6333-6333', 'CONDOM�NIO LUZ SE FER, APARTAMENTO 333, PARADOX CITY')
GO




--O C�DIGO ABAIXO RETORNA OS ATRIBUTOS NOME E IDADE DA TABELA PESSOA

SELECT NOME, IDADE FROM PESSOA
GO




--O COMANDO ABAIXO RETORNA O NOME DA PESSOA, CUJA IDADE SEJA IGUAL A 32.

SELECT NOME FROM PESSOA WHERE IDADE = 25
GO




--O C�DIGO ABAIXO RETORNA OS ATRIBUTOS NOME IDADE E ENDERE�O DO NOME EM QUEST�O

SELECT NOME, IDADE, ENDERECO FROM PESSOA WHERE NOME LIKE 'KATRINA BENNET LITT'
GO




--OBS.: SE POSS�VEL N�O UTILIZAR O COMANDO LIKE
--% � UM CARACTER CORINGA E AL�M DE RETORNA A IDADE E O ENDERE�O,
-- NO NOME, EM ESPEC�FICO, RETORNA TUDO O QUE VEM ANTES E DEPOIS DE LITT

SELECT NOME, IDADE, ENDERECO FROM PESSOA WHERE NOME LIKE '%LITT'
GO



--% � UM CARACTER CORINGA E AL�M DE RETORNA A IDADE E O ENDERE�O,
-- NO NOME, EM ESPEC�FICO, RETORNA TUDO O QUE VEM ANTES E DEPOIS DE BENNET

SELECT NOME, IDADE, ENDERECO FROM PESSOA WHERE NOME LIKE '%BENNET%'
GO



--RETORNA O NOME E ENDERE�O NA TABELA PESSOA ONDE O SEXO SEJA FEMININO E O ENDERE�O CONTENHA O NOME PARADOX EM ALGUMA PARTE
SELECT NOME, ENDERECO FROM PESSOA WHERE SEXO = 'F' AND ENDERECO LIKE '%PARADOX%'
GO


--RETORNA O NOME E ENDERE�O NA TABELA PESSOA ONDE O SEXO SEJA FEMININO OU O ENDERE�O CONTENHA O NOME PARADOX EM ALGUMA PARTE
SELECT NOME, ENDERECO FROM PESSOA WHERE SEXO = 'F' OR ENDERECO LIKE '%PARADOX%'
GO

--CONTA QUANTOS DADOS TEM NA TABELA PESSOA

SELECT COUNT(*) FROM PESSOA
GO



--CONTA QUANTOS DADOS TEM NA TABELA PESSOA
SELECT COUNT(*) AS 'CONTAGEM TOTAL DE PESSOAS' FROM PESSOA
GO


SELECT (36 * 63) AS 'MULTIPLICA��O DE 36 X 63'
GO

--SELECIONA O SEXO E CONTA QUANTOS DE CADA TEM EM QUANTIDADE AGRUPANDO POR SEXO
SELECT SEXO, COUNT(*) AS 'QUANTIDADE' FROM PESSOA GROUP BY SEXO
GO

--N�O EXECUTE ESSA MERDA! VAI ATUALIZAR TODOS OS ENDERE�OS DA TABELA PESSOA
UPDATE PESSOA SET ENDERECO = 'AVENIDA 666 DE DE DEZEMBRO, RUA DA CRUZ, ENCRUZILHADA DO NORTE'
GO

--ATUALIZA NA TABELA PESSOA E SETA NO ENDERE�O ONDE MEU ATRIBUTO NOME SEJA KATRINA BENNET
UPDATE PESSOA SET ENDERECO = 'ATUALIZA��O DE ENDERE�O' WHERE NOME = 'KATRINA BENNET'



--ADICIONA UM NOVO ATRIBUTO A TABELA PESSOA
ALTER TABLE PESSOA ADD IDPESSOA INT
GO


--IMPRIME O NOME A FRASE E A IDADE CONCATENADOS
SELECT CONCAT (NOME, ' TEM ', IDADE, ' ANOS') FROM PESSOA
GO


--DELETA DA TABELA PESSOA OS DADOS DE MARCOS
DELETE FROM PESSOA WHERE NOME = 'MARCOS'
GO

--CRIA UMA TABELA PRODUTO COM OS ATRIBUTOS INFORMADOS, 
--INSERE OS VALORES INFORMADOS
--CRIA UM NOVO ATRIBUTO CHAMADO SUBTOTAL COM O VALOR DA MULTIPLICA��O DA QUANTIDADE COM O VALOR UNIT�RIO
CREATE TABLE PRODUTO (NOME VARCHAR(36), QUANTIDADE INT, VALORUNITARIO MONEY)
GO

INSERT INTO PRODUTO VALUES ('�GUA MINERAL', 36, 6000.00)
GO

SELECT NOME, QUANTIDADE, VALORUNITARIO, (QUANTIDADE * VALORUNITARIO) AS 'SUBTOTAL' FROM PRODUTO
GO







