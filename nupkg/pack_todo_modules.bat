"..\src\.nuget\NuGet.exe" "pack" "..\src\common\ModularTodoApp.Utils\ModularTodoApp.Utils.csproj" -Properties Configuration=Release -IncludeReferencedProjects -Symbols
"..\src\.nuget\NuGet.exe" "pack" "..\src\TodoModule.Core\TodoModule.Core.csproj" -Properties Configuration=Release -IncludeReferencedProjects -Symbols
"..\src\.nuget\NuGet.exe" "pack" "..\src\TodoModule.EntityFramework\TodoModule.EntityFramework.csproj" -Properties Configuration=Release -IncludeReferencedProjects -Symbols
"..\src\.nuget\NuGet.exe" "pack" "..\src\TodoModule.Application\TodoModule.Application.csproj" -Properties Configuration=Release -IncludeReferencedProjects -Symbols
"..\src\.nuget\NuGet.exe" "pack" "..\src\TodoModule.Web\TodoModule.Web.csproj" -Properties Configuration=Release -IncludeReferencedProjects -Symbols
pause