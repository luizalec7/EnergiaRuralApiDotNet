# Energia Rural API

## Descri��o
API para c�lculo e gest�o de simula��es de pain�is solares para �reas rurais.

## Tecnologias
- ASP.NET Core 6
- Entity Framework Core
- Oracle Database
- Swagger

## Endpoints

### Usu�rio
- **POST /api/Usuario** - Criar um usu�rio.
- **GET /api/Usuario/{id}** - Obter um usu�rio e suas simula��es.

### Simula��o
- **POST /api/Simulacao** - Criar uma simula��o.
- **GET /api/Simulacao/{usuarioId}** - Obter simula��es de um usu�rio.

## Execu��o
1. Configure o arquivo `appsettings.json` com a string de conex�o do Oracle.
2. Execute `dotnet ef database update` para criar o banco.
3. Execute `dotnet run` para iniciar o servidor.
