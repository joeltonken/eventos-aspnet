# CRUD de Eventos

Este projeto � uma aplica��o MVC desenvolvida em .NET 6 para realizar opera��es CRUD (Create, Read, Update, Delete) em eventos. Ele utiliza um banco de dados SQL Server para armazenar os dados dos eventos.

## Pr�-requisitos

Antes de executar a aplica��o, certifique-se de ter os seguintes requisitos instalados:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/get-started)
- [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver18)

## Configura��o do Banco de Dados

Para configurar o banco de dados SQL Server, siga estas etapas:

1. Baixe a imagem do SQL Server usando o Docker:

```bash
docker pull mcr.microsoft.com/mssql/server
```

2. Execute o container do SQL Server:

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```


3. Baixe e instale o SQL Server Management Studio (SSMS) no seu sistema.

4. Abra o SSMS e conecte-se ao SQL Server usando as configura��es fornecidas no comando `docker run -e`.

5. Crie um banco de dados chamado `Eventos`.

6. Adicione as configura��es de conex�o ao banco de dados no arquivo `appsettings.json` da aplica��o.

## Executando a Aplica��o

Para executar a aplica��o, siga estas etapas:

1. Clone o reposit�rio para o seu sistema.

2. Navegue at� o diret�rio do projeto.

3. Execute o seguinte comando para restaurar as depend�ncias:

```bash
dotnet restore
```

4. Execute o seguinte comando para compilar a aplica��o:

```bash
dotnet build
```

5. Execute o seguinte comando para iniciar a aplica��o:


```bash
dotnet run
```


6. Acesse a aplica��o em seu navegador utilizando o endere�o `http://localhost:7014`.

## Funcionalidades

A aplica��o oferece as seguintes funcionalidades:

- Listagem de eventos
- Adi��o de novo evento
- Edi��o de evento existente
- Exclus�o de evento
- Exportar eventos em .xls

## Contribuindo

Sinta-se � vontade para contribuir com melhorias para este projeto. Basta seguir estas etapas:

1. Fork este reposit�rio.
2. Crie uma nova branch (`git checkout -b feature/nova-feature`).
3. Fa�a commit de suas altera��es (`git commit -am 'Adicione uma nova feature'`).
4. Fa�a push para a branch (`git push origin feature/nova-feature`).
5. Crie um novo Pull Request.