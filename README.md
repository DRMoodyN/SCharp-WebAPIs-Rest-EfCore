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


# JWT, Identity, And RefreshToken

Install Commnos
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Install WebAppHosting
Microsoft.EntityFrameworkCore.Design
Microsoft.AspNetCore.Authentication.JwtBearer
Install Services
AutoMapper.Extensions.Microsoft.DependencyInjection

JWT = Json WEb Token, consta de 3 partes
1) header o encabezado formato base64, tipo de token y nombre del algoritmo
{
 "alg": "HS256",
 "typ": "JWT"
 }

2) payload o carga utils datos sobre el usuario
{
 "sub": "1234567890",
 "name": "John Doe",
 "iat": 1516239022
}

3) signatura o firma
Por último, tenemos la parte de la firma. Por lo general, el servidor usa la firma
parte para verificar si el token contiene información válida, el
información que emite el servidor. Es una firma digital que se obtiene
generado al combinar el encabezado y la carga útil. Además, se basa
en una clave secreta que solo el servidor conoce: