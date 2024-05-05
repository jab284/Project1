using System;
using System.Collections.Generic;
using System.Security.Cryptography;
class Program
{
    //static void Main(string[] args)

    static List<string> taskList = new List<string>();

    //METHODS
    static string GetAndValidateUserInput(string inputName, int minLength, int maxLength)
    {
        //While Loop
        while (true)
        {
            //format strings for registering name            
            System.Console.WriteLine($"Please enter your {inputName}.  It must be between {minLength} and {maxLength} alpha characters long.");
            string input = Console.ReadLine();  //reads input from user
            try     //Exceptions -- wrong length
            {
                if (input.Length > maxLength || input.Length < minLength)
                {
                    throw new IndexOutOfRangeException($"Input must be between {minLength} and {maxLength} alpha characters long.");
                }

                for (int i = 0; i < input.Length; i++)

                {
                    if (!char.IsLetter(input[i]))      //invalid character exception
                    {
                        throw new FormatException("Input must only be alpha characters.");
                    }
                }
                // return to break out of while loop
                return input;      //??
            }
            catch (IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e);    //can i combine the e??
                System.Console.WriteLine($"Your {inputName} must be between {minLength} and {maxLength} alpha characters long.");
                System.Console.WriteLine("Please try again");
            }
            catch (FormatException e)
            {
                System.Console.WriteLine(e);    //can i combine the e??
                System.Console.WriteLine($"Your {inputName} must only be alpha characters");
                System.Console.WriteLine("Please try again");
            }
        }
    }

        //Method to register a user
    static User RegisterUser(string fullName, string userName, string password)
    {
        //create a new user object for next user
        User user = new User(fullName, userName, password);
        //return user object
        return user;   //??
    }

        //Method to Display main menu and make selection
    static int DisplayMainMenuAndGetSelection()
    {
        while (true)
        {
            System.Console.WriteLine("Main Menu");
            System.Console.WriteLine("[1] Add a new task");
            System.Console.WriteLine("[2] View all tasks");
            System.Console.WriteLine("[3] Exit");
            System.Console.WriteLine("Please select an option:");

            string input = Console.ReadLine();  //returns users input for selection
            try
            {
                int selection = int.Parse(input); //turn user input into int
                if (selection <1 || selection > 3)
                {
                    throw new IndexOutOfRangeException("Selection must be between 1 and 3.");
                }
                return selection;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);  //can i combine e
                System.Console.WriteLine("Selection is invalid");
                System.Console.WriteLine("Please try again.");
            }
        }
    }

        //Method Display Add Task
    static void DisplayAddTaskMenu()
    {
        System.Console.WriteLine("Please enter your task description.");
        string taskDescription = Console.ReadLine();

        taskList.Add(taskDescription);

        System.Console.WriteLine($"Task '{taskDescription}' added to your list.");
        //return taskDescription;   not needed?
    }
        //Method Display All Tasks
    static void DisplayAllTasks()
    {
         //I dont know how to do this);
    }



    //This is the MAIN
    static void Main(string[] args)
    {
        System.Console.WriteLine("'CREATE YOUR TO DO LIST'");
        System.Console.WriteLine("Here, you can easily maintain and track your list of need to do chores!");
        System.Console.WriteLine("Before starting your list you must first register with us.");
        //System.Console.WriteLine("Please start by entering your first name.");
        //Console.ReadLine();  //added  how to store?

        
        
        //Methods to login .............need reg methods

       //Method to get Full Name
        string fullName = GetAndValidateUserInput("Full Name", 4, 20);  // this is not working right
        System.Console.WriteLine(($"Welcome {fullName} "));
        //Method to get User Name
        string userName = GetAndValidateUserInput("Username", 7, 10);
        //Method to get Password
        string password = GetAndValidateUserInput("Password", 5, 10);   //not working as expected

        //Method to create RegisterUser with full name, user name, and password
        User user = RegisterUser(fullName, userName, password);
        //other stuff?  what to do here for registration?




        //Display Main menu
        DisplayMainMenuAndGetSelection();

        List<string> taskList = new List<string>();

        DisplayAddTaskMenu();

        bool exitRequested = false;

        while (!exitRequested)
        {
            int selection = DisplayMainMenuAndGetSelection();
            
            switch (selection)
            {
                case 1:
                    DisplayAddTaskMenu();
                    break;
                case 2:
                    DisplayAllTasks();
                    break;
                case 3:
                    System.Console.WriteLine("See you later!");
                    exitRequested = true;
                    break;
                default:
                    System.Console.WriteLine("Invalid selection.  Please select, 1, 2, or 3.");
                    break;
            }

            
        }

    }    
        
}



/*
        System.Console.WriteLine("'CREATE YOUR TO DO LIST'");
        System.Console.WriteLine("Here, you can easily maintain and track your list of need to do chores!");
        System.Console.WriteLine("Before starting your list you must first register with us.");
        System.Console.WriteLine("Please start by entering your first and last name.");
        Console.ReadLine();                                                                                                                  
        System.Console.WriteLine("Welcome ");
        
         
        System.Console.WriteLine("Please create a new User Name.  It must be between 7 and 10 alpha characters long.");
        string userNameInput = Console.ReadLine() ?? "0";
        try
        {
            //dont know what to put here

        }
        catch (IndexOutOfRangeException e)
        {
            System.Console.WriteLine(e);
            System.Console.WriteLine("Your user name must be between 7 and 10 alpha characters long.");
            System.Console.WriteLine("Please try again.");
        }
        catch (FormatException e)
        {
            System.Console.WriteLine(e);
            System.Console.WriteLine("Your user name must only be alpha characters.");
            System.Console.WriteLine("Please try again.");
        }
        System.Console.WriteLine("Thank you.  Now enter a password you would like to use to secure your account.");
        System.Console.WriteLine("The Password must be between 5 and 10 alpha numeric characters long");
        Console.ReadLine();

        try
        {
            //dont know what to put here

        }
        catch (IndexOutOfRangeException e)
        {
            System.Console.WriteLine(e);
            System.Console.WriteLine("Your password must be between 5 and 10 alpha characters long.");
            System.Console.WriteLine("Please try again.");
        }
        catch (FormatException e)
        {
            System.Console.WriteLine(e);
            System.Console.WriteLine("Your password can only be alpha numeric characters.");
            System.Console.WriteLine("Please try again.");
        }
        */