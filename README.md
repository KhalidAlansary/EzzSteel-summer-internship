# Ezz Steel Internship Project - Summer 2024

## Overview

This repository contains the final project submission for my summer internship at Ezz Steel in 2024. The project is a simple Windows Forms (WinForms) application developed using .NET and C#. It demonstrates the ability to interact with a SQL Server database, fetching data through SQL functions crafted within the database itself. The application leverages ADO.NET for database connectivity, showcasing fundamental database operations in a .NET environment.

## Features

- **Data Fetching:** Utilizes custom SQL functions to retrieve data from a SQL Server database.
- **Database Connectivity:** Employs ADO.NET for efficient and secure database connections.
- **User-Friendly Interface:** Offers a straightforward and intuitive WinForms user interface for data interaction.

## Prerequisites

Before running this application, ensure you have the following installed:

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (version specified in the project)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Ensure it's configured to work with ADO.NET)

## Setup and Installation

1. Clone the repository to your local machine:
    ```git clone https://github.com/yourusername/ezz-steel-internship-project-2024.git```
2. Open the solution file (`EzzSteelInternshipProject.sln`) in Visual Studio.
3. Ensure the connection string in the `App.config` file is updated to match your SQL Server instance.
4. **Restore the Database:**
    - Locate the `db.bak` file included in the repository.
    - Open SQL Server Management Studio (SSMS) and connect to your SQL Server instance.
    - Right-click on the Databases folder, select Restore Database...
    - Choose Device and click the button to browse for the `db.bak` file.
    - Select the file and proceed with the restoration process.
5. Build the solution (Build > Build Solution).
6. Run the application (Debug > Start Without Debugging).

## Usage

After launching the application, you can interact with the UI to perform data fetching operations. The application's interface is designed to be intuitive, guiding you through the process of selecting and viewing the data retrieved from the database.

## Contributing

As this project is a submission for an internship project, it is not open for contributions. However, feedback and suggestions are welcome.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Thanks to Ezz Steel for the opportunity to work on this project during my summer internship.
- Special thanks to my mentors and colleagues at Ezz Steel who provided guidance and support throughout the development process.
- A heartfelt acknowledgment to Engineer Youssif Gameel for his invaluable mentorship and insights that greatly contributed to the success of this project.

## Contact

For any inquiries or further information, please contact me through my GitHub profile.