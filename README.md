# ToDoList Application
Used **ASP.NET**, C#, and JavaScript to create a To-Do application.

I used the code first approach, which means defining models and classes and how they relate to each other in my code. I  leveraged Entity Framework, which is part of ASP.NET, to build the database looking at the code.
+ Create a Class in Models to get information from the Users.

 - In the IdentityModels, I added a table called ToDo to store the data from the user. I enable migration that creates a Configuration class and that allows us to seed our database when created and so we don't have to create a new user every time we are testing our code.
 - In the configuration class, a function was created to add users
 - Created a Controllers with views, using Entity Framework.
 - In the ToDoes Controller, we have methods to Create, Edit, and Delete and have a class called Index.

Utilized JavaScript along with AJAX to allow users to continue creating ToDos from one page without having to save one ToDo to the database at a time. 
+ Users can delete a list, edit and view details about their list.
+ Users can pick a due date for each item on their list.
+ Used CSS to create a line that crosses an item showing that the item is completed.
In this project, I used a couple of online resources and watched some videos to help with debugging.
