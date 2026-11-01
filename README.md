# Sistema de Cadastro para Academia

Projeto de estudo desenvolvido em C# para gerenciar cadastros de alunos de uma academia, utilizando uma interface desktop com Windows Forms.

## Funcionalidades

- Cadastro de dados pessoais e documentação.
- Registro de objetivos, modalidades e preferência de horário.
- Consulta individual e listagem geral dos cadastros.
- Atualização e exclusão de registros.

## Tecnologias

- C#
- Windows Forms
- .NET Framework 4.7.2
- SQL Server LocalDB
- ADO.NET

## Como executar

1. Utilize um computador com Windows.
2. Instale o Visual Studio com a carga de trabalho
   "Desenvolvimento para desktop com .NET"
   e o pacote de destino do .NET Framework 4.7.2.
3. Instale o SQL Server Express LocalDB.
4. Baixe ou clone este repositório.
5. Abra o arquivo `Projeto CRUD.csproj` no Visual Studio.
6. Configure o banco de dados conforme a conexão em `Conexao.cs`.
7. Compile e execute o projeto.

### Banco de dados

A aplicação utiliza a instância `(localdb)\MSSQLLocalDB`,
o banco `ProjetoCRUD` e a tabela `Cadastro`.

O script de criação do banco ainda precisa ser incluído
para permitir a configuração completa em outro computador.

## Aprendizados

Prática de operações CRUD, construção de interfaces gráficas,
validação de campos e integração com banco de dados relacional.

## Status

Projeto de estudo em evolução.
