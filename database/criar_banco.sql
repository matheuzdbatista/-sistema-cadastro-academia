-- Banco de dados do Sistema de Cadastro para Academia.
-- Execute na instancia (localdb)\MSSQLLocalDB.

USE master;
GO

IF DB_ID(N'ProjetoCRUD') IS NULL
BEGIN
    EXEC(N'CREATE DATABASE ProjetoCRUD');
END;
GO

USE ProjetoCRUD;
GO

IF OBJECT_ID(N'dbo.Cadastro', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Cadastro
    (
        Id             INT           NOT NULL,
        Nome           NVARCHAR(200) NOT NULL,
        Telefone       NVARCHAR(30)  NOT NULL,
        Endereco       NVARCHAR(300) NOT NULL,
        CEP            NVARCHAR(20)  NOT NULL,
        Cidade         NVARCHAR(150) NOT NULL,
        Estado         NVARCHAR(50)  NOT NULL,
        Sexo           NVARCHAR(30)  NOT NULL,
        DataNascimento NVARCHAR(30)  NOT NULL,
        CPF            NVARCHAR(20)  NOT NULL,
        RG             NVARCHAR(30)  NOT NULL,
        Objetivo       NVARCHAR(100) NOT NULL,
        Modalidades    NVARCHAR(300) NOT NULL,
        Horario        NVARCHAR(30)  NOT NULL,

        CONSTRAINT PK_Cadastro PRIMARY KEY (Id)
    );

    PRINT N'Tabela Cadastro criada com sucesso.';
END
ELSE
BEGIN
    PRINT N'A tabela Cadastro ja existe e foi mantida.';
END;
GO
