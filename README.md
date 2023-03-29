# curso-fundamentos-entity-framework

dotnet new web //Para crear una minimal api desde la consola


Comandos Migraciones:

Documentacion herramienta: https://learn.microsoft.com/en-us/ef/core/cli/dotnet

dotnet ef //Para ver si se tiene instalada la herramienta para manejar migraciones

dotnet tool install --global dotnet-ef  //Para instalar la herramienta

dotnet tool update --global dotnet-ef  // Para actualizar la herramienta

dotnet ef migrations add InitialCreate // Para crear la primera migración

dotnet ef migrations add MyMigration // Adicionar más migraciones

dotnet ef database update // este comando se ejecuta cada vez que se hace una migración. Cuando es la primera migración o la inicial se debe borrar la base de datos para que quede la tabla de migraciones
