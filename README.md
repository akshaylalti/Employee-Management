# Employee Management CRUD Project

This project demonstrates a simple Employee Management system with CRUD (Create, Read, Update, Delete) operations. It utilizes the following technologies:

- Angular (Frontend)
- ASP.NET Core API (Backend)
- SQL Server with Entity Framework (Database)

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Database Schema](#database-schema)
- [Contributing](#contributing)
- [License](#license)

## Features

- Create, Read, Update, and Delete employees
- Angular for a responsive and dynamic frontend
- ASP.NET Core API for handling backend operations
- SQL Server with Entity Framework for data storage
- RESTful API design for easy integration with various clients

## Prerequisites

Before you begin, ensure you have the following installed:

- Node.js and npm (for Angular)
- .NET SDK (for ASP.NET Core)
- SQL Server
- Visual Studio Code or Visual Studio

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/employee-management-crud.git
   ```

2. Navigate to the frontend directory and install dependencies:

   ```bash
   cd employee-management-crud/frontend
   npm install
   ```

3. Navigate to the backend directory and restore packages:

   ```bash
   cd employee-management-crud/backend
   dotnet restore
   ```

## Usage

1. Set up the SQL Server database by updating the connection string in `appsettings.json` in the backend project.

2. Run the migrations to create the database:

   ```bash
   cd employee-management-crud/backend
   dotnet ef database update
   ```

3. Start the backend API:

   ```bash
   cd employee-management-crud/backend
   dotnet run
   ```

4. Start the frontend application:

   ```bash
   cd employee-management-crud/frontend
   ng serve
   ```

5. Open your browser and navigate to `http://localhost:4200/` to access the Employee Management application.

## API Endpoints

- `GET /api/employees`: Get a list of all employees
- `GET /api/employees/{id}`: Get details of a specific employee
- `POST /api/employees`: Create a new employee
- `PUT /api/employees/{id}`: Update details of a specific employee
- `DELETE /api/employees/{id}`: Delete a specific employee

## Database Schema

The database schema includes a table named `Employees` with fields such as `EmployeeId`, `FirstName`, `LastName`, `Email`, `PhoneNumber`, etc. Refer to the backend project's code for the complete database model.

## ScreenShot
[![MasterHead](https://akshay-kumar93.web.app/img/portfolio/CRUD.png
)](https://akshaylalti.io)
## Contributing

Feel free to contribute to the project by opening issues or submitting pull requests. Follow the [Contributing Guidelines](CONTRIBUTING.md) for more details.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```

.
