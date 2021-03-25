# ToDoList Application
Using **ASP.NET Web Application** to create a To-Do application.

To get this application to work, I used the code first approach, which means to define models and classes and how they relate to each other in my code, and the Identity framework, which is part of 
ASP.NET to build the database looking at the code.

+ Create a Class in **Models** to get information from the Users.
  - In the IdentityModels, I added a table called ToDo to collect the database from the user.
I enable migration that creates a Configuration class and that allows us to seed our database when created and so we don't have to create a new user every time we are testing our codes.
  - In the configuration class, a function was created to add users 
  
 Created a **Controllers** with views, using Entity Framework.
 
In the ToDoes Controller we have a file to Create, Edit, and Delete and have a class called Index

Using some javascript for my table and for the javascript to be able to work I have to used **Ajax**
When users click on create and fill out the information they have the option to keep creating or to save and return to the main menu.

  - Users can delete a list, edit and view details about their list.
  - Users can pick a date for their list
  - Using CSS to create a line that crosses a list showing that the list is completed.

In this project, I used a couple of online resources and watch some youtube videos for some debugging.
