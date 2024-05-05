# csharp comandos

# gerar paginas
| Parâmetro                        | descrição                                                        | 
| ---                              |    ---                                                           |
|-name                             | nome do controlador                                              |
| -M                               | O nome do modelo.                                                |
| -dc                              | O contexto de dados.                                             |
| --relativeFolderPath Controllers | O caminho da pasta de saída relativa para criar os arquivos.     |
| --useDefaultLayout               | O layout padrão deve ser usado para as exibições.                |
|--referenceScriptLibraries        | Adiciona _ValidationScriptsPartial para Editar e Criar páginas.  |
|--databaseProvider sqlite	       | Especifique que DbContext deve usar o SQLite em vez do SQL Server|
---
# Exemplo
```
dotnet aspnet-codegenerator controller               \
-name AlunosController                               \
-m     Aluno                                         \
-dc projeto.Models.AppDbContext                      \
--relativeFolderPath Controllers                     \
--useDefaultLayout                                   \
--referenceScriptLibraries                           \
--databaseProvider Pomelo.EntityFrameworkCore.MySql  \
```
---
# fazer migrations
| Parâmetro                     | descrição        |
| ---                           | ---              |  
| dotnet ef migrations add nome | nome da migração |
| dotnet ef database update     | atualiza database|   
---
# adiciona pacotes
| Parâmetro                              | descrição                      |
| ---                                    | ---                            |
| dotnet add package nome_do_pacote      | adiciona um pacote na aplicação|

---
# Exemplo
```dotnet add package Pomelo.EntityFrameworkCore.MySql```


