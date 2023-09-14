# ASP.Net Core MVC Template Project with Entity Framework Auto-Migrations

Welcome to the ASP.Net Core MVC Template Project with Entity Framework Auto-Migrations! This project aims to provide you with a robust infrastructure for building ASP.Net Core applications that connect to a Microsoft SQL Server database using Entity Framework. It simplifies the process of database schema management by automating migrations through the NuGet Package Manager Console.

## Getting Started

To get started with this template project, follow these steps:

1. **Clone the Repository:** Clone this repository to your local machine using the following command:

   ```bash
   git clone https://github.com/your-username/ASP.Net-Core-MVC-Template-Project-With-EntityFrameworks-auto-migrations.git
   ```

2. **Database Configuration:**

   - Open the `appsettings.json` file and configure your database connection string in the `"ConnectionStrings"` section.

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=your-server;Database=your-database;User=your-username;Password=your-password;"
   }
   ```

3. **Run Migrations:**

   - Open the NuGet Package Manager Console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console).

   - Run the following commands to create and apply the initial database migration:

     ```bash
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

   This will automatically generate the database schema based on your Entity Framework model classes.

4. **Start Coding:** You're all set! You can now start building your ASP.Net Core MVC application on top of this template. Feel free to add controllers, views, models, and any other components you need for your project.

## Project Structure

Here's an overview of the project structure:

- **Controllers:** Contains the ASP.Net Core MVC controllers for your application.
- **Models:** Place your Entity Framework models (representing database tables) here.
- **Views:** Contains the Razor views for your MVC application.
- **Migrations:** Auto-generated migration files will be stored here.
- **Data:** Contains the database context and any data-related configurations.
- **wwwroot:** This is where you can place your static files like CSS, JavaScript, and images.
- **Startup.cs:** Configure your application services and middleware in this file.
- **appsettings.json:** Configure your application settings and database connection string here.

## Contributing

We welcome contributions from the community to improve this template project. If you have any suggestions, bug reports, or feature requests, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

Thank you for choosing this ASP.Net Core MVC Template Project with Entity Framework Auto-Migrations. We hope it accelerates your development process and makes building ASP.Net Core applications with Entity Framework more straightforward.

Happy coding!
