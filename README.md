# Employee Management System (ASP.NET Core MVC)

## Overview
This is an ASP.NET Core MVC application that implements CRUD (Create, Read, Update, Delete) operations for managing employees. The project follows best practices and utilizes Entity Framework Core for database operations.

## Features
- List all employees
- Add a new employee
- Edit employee details
- Delete an employee (with confirmation)
- Proper validation for inputs

## Technologies Used
- **ASP.NET Core 8.0.0** (downgraded from 9.0.0 due to compatibility issues with Pomelo MySQL 8.0.0)
- Entity Framework Core
- Pomelo MySQL 8.0.0
- Razor Pages (Views)
- Git & SourceTree for version control

## Prerequisites
Ensure you have the following installed:
- .NET SDK 8.0.0
- Visual Studio 2022 (or later)
- MySQL Server
- Git & SourceTree

## Setup Instructions
1. **Clone the Repository**
   ```sh
   git clone <repository-link>
   cd EmployeeManagementSystem
   ```

2. **Configure the Database**
   - Update the `appsettings.json` file with your MySQL connection string:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "server=localhost;database=EmployeeDB;user=root;password=yourpassword;"
     }
     ```

3. **Apply Migrations**
   Run the following commands to create the database schema:
   ```sh
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Run the Application**
   ```sh
   dotnet run
   ```
   Open a browser and go to `http://localhost:5000`.

## Project Structure
- **Models/** → Contains `Employee.cs` class
- **Data/** → Contains `AppDbContext.cs`
- **Controllers/** → Contains `EmployeeController.cs` for CRUD logic
- **Views/** → Contains Razor views for listing, creating, editing, and deleting employees

## CRUD Operations
- **List Employees** → Navigate to `/Employee`
- **Add Employee** → Navigate to `/Employee/Create`
- **Edit Employee** → Navigate to `/Employee/Edit/{id}`
- **Delete Employee** → Navigate to `/Employee/Delete/{id}`

## Submission
The project has been successfully submitted via GitHub using SourceTree.

## Troubleshooting
- If you face any issues with MySQL connectivity, ensure the server is running and the connection string is correct.
- If migrations fail, try deleting the `Migrations` folder and re-running the migration commands.

## Author
- **Abdullah Al-Juhani**

