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
