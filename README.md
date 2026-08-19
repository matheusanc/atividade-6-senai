Execute a aplicação no terminal:

Bash
dotnet restore
dotnet build
dotnet run


Gerar Token: Envie uma requisição POST para https://localhost:<porta>/api/usuarios com o corpo JSON:

JSON
{
  "email": "email@sp.br",
  "senha": "1234"
}
