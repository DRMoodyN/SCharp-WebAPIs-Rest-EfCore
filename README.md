# Scharp-WebAPIs-EF-Wms

# Proeject Configuration 
La configuración en .NET Core es muy diferente a lo que estamos acostumbrados en 
Proyectos de .NET Framework. Ya no usamos el archivo web.config, pero en su lugar,
usamos un marco de configuración integrado que viene listo para usar en .NET Core

# Creatin new project CLI 
dotnet new classlib -n Commons 
dotnet new classlib -n Models 
dotnet new classlib -n Repository 
dotnet new classlib -n Services 
dotnet new webapi -n WebAppHosting 
dotnet new sln -n Solution
dotnet sln Solution.sln add **/*.csproj 

# CLI 
dotnet restore
dotnet clean
dotnet build
dotnet run

# https://localhost:7061/swagger/index.html

# Install Models 
Instalacion de paquetes nugget Models 
Microsoft.EntityFrameworkCore -v 6.0.7 
Microsoft.EntityFrameworkCore.SqlServer -v 6.0.7 
Microsoft.EntityFrameworkCore.Tools -v 6.0.7

# CLI dotnet ef 
dotnet ef migrations add testing 
dotnet ef database update testing 
dotnet ef database drop

# ConnectionString
dotnet ef dbcontext scaffold "Server=localhost;Database=ProjectAccouting;User=LoginAccouting;Password=Pr#j3c7@cc##%ti*+;" Microsoft.EntityFrameworkCore.SqlServer -o Entitiess --context-dir Context -c AccoutingDBContext --force

# https://learn.microsoft.com/en-us/ef/core/