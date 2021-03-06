CREATE DATABASE PRIMEIRAFORMA
GO

USE PRIMEIRAFORMA
GO



CREATE TABLE PESSOA(
     IDPESSOA INT NOT NULL PRIMARY KEY IDENTITY(1,1), --O ID PESSOA ? UM INTEIRO N?O NULO E QUE N?O PODE RECEBER UM VALOR VAZIO.
	 NOME VARCHAR(100),                               --O IDENTITY ? UM INCREMENTO QUE INICIA DE 1 OU ALGUM VALOR DEFINIDO E CONTA DE 1 EM 1 OU UM VALOR DEFINIDO
	 IDADE INT,                                --NO GERAL O IDENTITY INDICA QUE O ATRIBUTO EM QUEST?O ? O QUE VAI INICIAR A CONTAGEM.
	 SEXO CHAR(1),                                    
	 CPF VARCHAR(16) UNIQUE
)
GO
 
   
CREATE TABLE ENDERECO (
     IDENDERECO INT PRIMARY KEY IDENTITY,
	 CEP VARCHAR(9), 
     ENDERECO VARCHAR(45),
	 COMPLEMENTO VARCHAR(45), 
     CIDADE VARCHAR(27),  
     UF CHAR(2),
	 ID_PESSOA INT UNIQUE, --UNIQUE ? UMA "CARDINALIDADE IMPL?CITA" AQUI DIZ QUE UMA PESSOA N?O PODE TER MAIS DE UM ENDERE?O
	 
	 --CRIA UMA CHAVE ESTRANGEIRA DENOMINADA ID_PESSOA QUE FAR? REFER?NCIA, NA TABELA PESSOA, AO IDPESSOA.
	 CONSTRAINT FK_ID_PESSOA FOREIGN KEY (ID_PESSOA) REFERENCES PESSOA(IDPESSOA)
)
GO


CREATE TABLE TELEFONE (
     IDTELEFONE INT PRIMARY KEY IDENTITY,
	 TELEFONEFIXO VARCHAR(21), 
     TELEFONECELULAR VARCHAR(21), 
	 ID_PESSOA INT,

	 CONSTRAINT FK_ID_PESSOA_TELEFONE FOREIGN KEY (ID_PESSOA) REFERENCES PESSOA(IDPESSOA)
)
GO

SELECT NOME, CPF, CEP, ENDERECO --PROJETE O NOME, CPF, CEP E ENDERECO 
      FROM PESSOA --DA TABELA PESSOA
	  INNER JOIN ENDERECO --E JUNTE A TABELA PESSOA COM O ENDERECO
	  ON IDPESSOA = ID_PESSOA --ONDE A CHAVE PRIM?RIA(IDPESSOA) SEJA IGUAL A CHAVE ESTRANGEIRA(ID_PESSOA)
	  WHERE SEXO = 'F'--E O SEXO SEJA FEMININO
GO



SELECT P.NOME, P.IDADE, P.CPF, E.CEP, E.UF, T.TELEFONECELULAR FROM PESSOA P  --USANDO UM ALIAS(APELIDO) PARA FAZER A JUN?AO DE V?RIAS TABELAS ALIAS = PESSOA P; TELEFONE T; ENDERECO E, ETC.
	  INNER JOIN ENDERECO E ON IDPESSOA = E.ID_PESSOA
	  INNER JOIN TELEFONE T ON IDPESSOA = T.ID_PESSOA
	  WHERE SEXO = 'F'
GO




SP_HELP PESSOA
GO

INSERT INTO ENDERECO VALUES('68908-814','Rua Yasmin Brito', 'Infraero', 'Macap?', 'RR', 6) --O N?MERO 6 ? O N?MERO DO ID DA TERCEIRA PESSOA, O QUAL O ENDRE?O ? INSERIDO.
GO

INSERT INTO PESSOA VALUES('Enzo Nespoli Quintanilha', 36, 'M', '765.275.344-93')
GO

INSERT INTO TELEFONE VALUES('(99) 2290-3315', '(98) 96752-5744', 6)
GO

SELECT *FROM PESSOA
GO

SELECT *FROM ENDERECO
GO

SELECT *FROM TELEFONE
GO

DELETE FROM PESSOA WHERE NOME = 'SUENIA BAESSO SOARES '
GO




