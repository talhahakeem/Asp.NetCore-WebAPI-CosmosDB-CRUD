# ASP.NET Core Web API with Azure Cosmos DB (CRUD)

This project demonstrates a robust implementation of a RESTful Web API using **ASP.NET Core** and **Azure Cosmos DB**. It follows industry best practices, including the **Repository Pattern** and **Dependency Injection**, to ensure the code is scalable and maintainable.



## 1. Features
* **Full CRUD Operations:** Create, Read, Update, and Delete documents in Cosmos DB.
* **Asynchronous Programming:** Fully `async/await` based implementation for better scalability.
* **Repository Pattern:** Decouples data access logic from the controllers.
* **Environment Configuration:** Secure handling of Connection Strings and Primary Keys.
* **Swagger/OpenAPI:** Integrated UI for easy API testing.

## 2. Tech Stack
* **Framework:** .NET 8.0 / 9.0 (ASP.NET Core)
* **Database:** Azure Cosmos DB (NoSQL)
* **SDK:** Microsoft.Azure.Cosmos
* **Documentation:** Swagger UI

## 3. Project Structure
```text
├── Controllers/        # API Endpoints
├── Models/             # Data Entities
├── Services/           # Business Logic / Repository Interface
├── Data/               # Cosmos DB Context & Implementation
├── AppSettings.json    # Configuration (CosmosDB URI & Key)
└── Program.cs          # Dependency Injection & Middleware
4. Getting Started
Prerequisites
Azure Account: An active Azure Cosmos DB instance (or use the Cosmos DB Emulator).

.NET SDK: Installed on your machine.

Visual Studio / VS Code

Configuration
Update your appsettings.json with your Azure credentials:
"CosmosDb": {
  "Account": "https://localhost:8081",
  "Key": "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
  "DatabaseName": "StudentPortalDb",
  "ContainerName": "Students"
}
```
Developed by MUHAMMAD TALHA HAKEEM
