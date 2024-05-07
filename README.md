# CRUD de Eventos

Este projeto é uma aplicação MVC desenvolvida em .NET 6 para realizar operações CRUD (Create, Read, Update, Delete) em eventos. Ele utiliza um banco de dados SQL Server para armazenar os dados dos eventos.

## Pré-requisitos

Antes de executar a aplicação, certifique-se de ter os seguintes requisitos instalados:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/get-started)
- [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver18)

## Configuração do Banco de Dados

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

4. Abra o SSMS e conecte-se ao SQL Server usando as configurações fornecidas no comando `docker run -e`.

5. Crie um banco de dados chamado `Eventos`.

6. Adicione as configurações de conexão ao banco de dados no arquivo `appsettings.json` da aplicação.

## Executando a Aplicação

Para executar a aplicação, siga estas etapas:

1. Clone o repositório para o seu sistema.

2. Navegue até o diretório do projeto.

3. Execute o seguinte comando para restaurar as dependências:

```bash
dotnet restore
```

4. Execute o seguinte comando para compilar a aplicação:

```bash
dotnet build
```

5. Execute o seguinte comando para iniciar a aplicação:


```bash
dotnet run
```


6. Acesse a aplicação em seu navegador utilizando o endereço `http://localhost:7014`.

## Funcionalidades

A aplicação oferece as seguintes funcionalidades:

- Listagem de eventos
- Adição de novo evento
- Edição de evento existente
- Exclusão de evento
- Exportar eventos em .xls

## Contribuindo

Sinta-se à vontade para contribuir com melhorias para este projeto. Basta seguir estas etapas:

1. Fork este repositório.
2. Crie uma nova branch (`git checkout -b feature/nova-feature`).
3. Faça commit de suas alterações (`git commit -am 'Adicione uma nova feature'`).
4. Faça push para a branch (`git push origin feature/nova-feature`).
5. Crie um novo Pull Request.