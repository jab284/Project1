# Project1

OVERVIEW:
    General overview
    App features

HOW APP WORK:

VISUALIZATION LAYER:
    The visualization layer is abstracted into a group of methods under the Main method in the Program class. This allows for a separation of concerns between the main method and what's powering our UI. It houses the app's many menus.

CONTROLLER LAYER:
    For this app, this layer doesn't contain any business logic around permissioning or authorization. It is just a pass-through layer to the service layer.

SERVICE LAYER:
    This layer is the core of the app's business logic. It houses logic for the primary actions a user can take in the app--registering, logging in, adding todos, and getting todos.

REPOSITORY LAYER:
    This layer is an abstraction over the data access layer that lets us get and save data without worrying about the database interactions. Here, we can define the CRUD operations, getting and saving todos and users, to be used by the service layer.

DATA ACCESS LAYER:
    For this layer, I am using Entity Framework to access the app's data from the database. The data models for User and Todo are used to set up our database context, so Entity Framework can track their changes and perform CRUD operations on our database for those models.

HOW TO RUN APP:
    Create a folder and clone this repo
    Update the path to your database configuration file in <folder>/Util/TodoListContext.cs
    Swap out the path to the configuration file in the TodoListContext constructor for the path to your configuraiton string file.
    Run: dotnet ef database update
    Run the app: dotnet run

Test for errors:
Register username that already exists
Login with a username that doesn’t exit
Login with bad password
Registering a user make the password too short
Login Successful
