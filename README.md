# Energia Rural API

## Descrição
API para cálculo e gestão de simulações de painéis solares para áreas rurais.

## Tecnologias
- ASP.NET Core 6
- Entity Framework Core
- Oracle Database
- Swagger

## Endpoints

### Usuário
- **POST /api/Usuario** - Criar um usuário.
- **GET /api/Usuario/{id}** - Obter um usuário e suas simulações.

### Simulação
- **POST /api/Simulacao** - Criar uma simulação.
- **GET /api/Simulacao/{usuarioId}** - Obter simulações de um usuário.

## Execução
1. Configure o arquivo `appsettings.json` com a string de conexão do Oracle.
2. Execute `dotnet ef database update` para criar o banco.
3. Execute `dotnet run` para iniciar o servidor.
