# Asp.Net-Core-Web-Api-Auth-Template

### Dotnet Web Api application startup template with JWT authentication, AspNetCore Identity and Login/Register features.<br />

#### To initialize the database using code-first approach with entity framework tools:<br />
-fill the connection string in appsettings.json file<br />
-make sure to install dotnet ef tools (to install the EF Core tools globally run ```dotnet tool install -g dotnet-ef```)<br />
-create first migration (```dotnet ef migrations add InitialCreate```)<br />
-update your database (```dotnet ef database update```)<br />

#### Framework<br />
~.Net 6.0<br />
#### Database<br />
~Microsoft Sql Server<br />