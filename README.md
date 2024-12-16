
# 🚀 Microservicio de gestión de acceso

Este proyecto utiliza .NET 8 como framework principal y MS SQL Server como base de datos. A continuación, encontrarás las instrucciones para configurar, ejecutar y entender este proyecto.

## ⚙️ Requisitos Previos

Antes de comenzar, asegúrate de tener lo siguiente instalado en tu máquina:

- **[.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)** o superior 
- **[MS SQL Server](https://www.microsoft.com/es-cl/sql-server/sql-server-downloads)** (Local o remoto)
- **[SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)** (Opcional, para administración de la base de datos)
- **[Git](https://git-scm.com/downloads)** (Para clonar el repositorio)

## 🛠️ Configuración Inicial

1. **Clona el Repositorio**
   
   ```bash
   git clone https://github.com/Byte-Arquitect/AccessService.git
   cd /AccessService
   ```

2. **Restaura las Dependencias**

   ```bash
   dotnet restore
   ```

3. **Configura la Base de Datos**

   - Asegúrate de que tu instancia de SQL Server esté ejecutándose.
   - Asegúrate que la cadena de conexión en `appsettings.json` se vea de la siguiente manera:

     ```json
     "ConnectionStrings": {
         "DefaultConnection": "Server=localhost;Database=AccessServiceDB;Trusted_Connection=True;TrustServerCertificate=True;"
     }
     ```

4. **Aplica las Migraciones**


   ```bash
   dotnet ef database update
   ```

   Esto creará todas las tablas necesarias en tu base de datos, con un usuario base que tendra las credenciales:
   
   **Email:** jane.doe@example.com

   **Contraseña:** hashed_password_123


5. 🚀 **Ejecuta el Proyecto**

   ```bash
   dotnet run
   ```

   La API estará disponible en [https://localhost:5238](https://localhost:5238) por defecto.

## 📋 Endpoints

A continuación, se describen los endpoints principales de la API. Puedes utilizar herramientas como Postman o Swagger para probarlos.

- **POST api/Auth/login**: Permite logear al usuario.
- **POST api/Auth/revoke**: Permite revocar el token de acceso.
