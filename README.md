# 📦 Sistema de Gestión de Pedidos
**Desarrollado por Valentín Lucero**

### 🚀 Descripción
Este es un sistema integral para la gestión de órdenes de compra, clientes y stock, desarrollado bajo una **Arquitectura Multicapa** para garantizar escalabilidad y mantenimiento.

### 🛠️ Tecnologías Utilizadas
* **Lenguaje:** C# (.NET Framework/Core)
* **Base de Datos:** SQL Server (T-SQL)
* **Arquitectura:** Diseño en 5 capas (UI, BLL, DAL, Entitys, Mappers)
* **Herramientas:** Visual Studio, Git/GitHub

### 📐 Arquitectura del Sistema
El proyecto se divide en las siguientes capas para separar responsabilidades:
* **UI (User Interface):** Interfaz gráfica en Windows Forms.
* **BLL (Business Logic Layer):** Reglas de negocio y validaciones.
* **DAL (Data Access Layer):** Conexión y persistencia con SQL Server mediante ADO.NET.
* **ENTITYS:** Clases de dominio que representan los objetos del sistema.
* **MAPPERS:** Lógica de transformación de datos.

### 🔧 Instalación
1. Clonar el repositorio.
2. Ejecutar el script `Script_Tablas.sql` en SQL Server.
3. Configurar la cadena de conexión en el `App.config` o clase de conexión.
4. Abrir `UI.sln` y ejecutar.
