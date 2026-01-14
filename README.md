Building POC Web Application Using Asp.Net Web API And AngularJS

BookStore-Web-API-Master Web Application

Welcome to the Online Bookshop Management ASP.NET MVC project! This web application allows you to manage your bookshop efficiently, including master-details CRUD operations. Each book can be categorized, and the project features dynamic CSS to enhance the user interface.

Key Features
•	Master-Details CRUD: Manage books, categories, and book details seamlessly through Create, Read, Update, and Delete operations.
•	Categorized Books: Organize books into categories, making it easier for customers to find their preferred genres.
•	Dynamic CSS: Enhance the user interface with dynamic CSS styles to create an engaging and visually appealing website.  

Frameworks - Libraries
1.	ASP.NET Web API- The primary framework for building web applications in C#.
2.	Entity Framework- Used for data modeling and database access.
3.	Autofac
4.	Automapper
5.	FluentValidation
6.	AngularJS
7.	Bootstrap 3
8.	3rd part libraries
   
Usage
To use the Online Bookshop Management ASP.NET MVC project:
1.	Clone the Repository: Clone this repository to your local machine using Git.
git clone https://github.com/kalaivanansenthilkumar/bookstore-web-api-master.git
2.	Set Up the Database: Configure your database settings in the project to store book and category information.
3.	Build and Run: Open the project in Visual Studio or your preferred ASP.NET development environment. Build the solution and run the application to start managing your bookshop.
4.	Explore Features: Use the web interface to add, edit, and delete books, assign categories, and experience the dynamic CSS styles.
   
Installation instructions
1.	Build solution to restore packages
2.	Rebuild solution
3.	Change the connection strings inside the BookStore.Data/App.config and BookStore.Web/Web.config accoarding to your development environment
4.	Open Package Manager Console
5.	Select BookStore.Data as Default project (in package manager console) and run the following commands
i.	add-migration "initial"
ii.	update-database -verbose
6.	Run BookStore.Web application

Contributing
Contributions to this project are welcome. If you have suggestions for improving the functionality, adding new features, enhancing the user interface, or optimizing code, please feel free to contribute by submitting pull requests or opening issues.

License
This project is provided under an open-source license (insert the license type). You are free to use, modify, and distribute the application as per the terms of the license. Please refer to the LICENSE file for details.
