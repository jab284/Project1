using System;
using System.Collections.Generic;
using System.Security.Cryptography;
class Program
{
    //static void Main(string[] args)

    //static List<string> taskList = new List<string>();

    //METHODS
    static string GetAndValidateUserInput(string inputName, int minLength, int maxLength)
    {
        //While Loop
        while (true)
        {
            //format strings for registering name            
            System.Console.WriteLine($"Please enter your {inputName}.  It must be between {minLength} and {maxLength} alpha characters long.");
            string input = Console.ReadLine();  //reads input from user
            try     //Exceptions --  for wrong length
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
                return input;      //users input
            }
            catch (IndexOutOfRangeException e)
            {
                
                System.Console.WriteLine($"Your {inputName} must be between {minLength} and {maxLength} alpha characters long.");
                System.Console.WriteLine("Please try again.");
            }
            catch (FormatException e)
            {
                
                System.Console.WriteLine($"Your {inputName} must only be alpha characters");
                System.Console.WriteLine("Please try again.");
            }
        }
    }

        //Method to register a user
    static User RegisterUser(string fullName, string userName, string password)
    {
        //create a new user object for next user
        User user = new User(fullName, userName, password);
        //return user object
        return user;   //return new user
    }

        //Method to Display main menu and make selection
    static int DisplayMainMenuAndGetSelection()
    {
        while (true)
        {
            
            
            System.Console.WriteLine("Main Menu:");
            System.Console.WriteLine("What would you like to do next?");
            System.Console.WriteLine();
            System.Console.WriteLine("[1] Add a new task");
            System.Console.WriteLine("[2] View all tasks");
            System.Console.WriteLine("[3] Exit");
            System.Console.WriteLine();
            System.Console.WriteLine("Please select an option:");

            string input = Console.ReadLine();  //returns users input for selection
            System.Console.WriteLine();
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
                System.Console.WriteLine("Sorry!  Your selection is invalid.");
                System.Console.WriteLine("Selection must be between 1 and 3.  Please try again.");
                System.Console.WriteLine();
            }
        }
    }

        //Method Display Add Task
    static void DisplayAddTaskMenu(User activeUser)
    {
        activeUser.AddTask();
    }
        //Method Display All Tasks
    static void DisplayAllTasks(User activeUser)
    {
        System.Console.WriteLine("YOUR LIST OF TASKS:");
        System.Console.WriteLine();
        List<string> Tasks = activeUser.TaskList;
        foreach (string Task in Tasks)
        {
            System.Console.WriteLine(Task);
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }



    //This is the MAIN --------------------------------------------
    static void Main(string[] args)

            //This is UI Development for 
    {
        System.Console.WriteLine("*************************");
        System.Console.WriteLine(" CREATE YOUR TO DO LIST ");
        System.Console.WriteLine("*************************");
        System.Console.WriteLine();
        System.Console.WriteLine("Here, you can easily maintain and track your list of need to do chores!");
        System.Console.WriteLine();
       
       

        
        
        //Methods to register ....

       //Method to get Full Name
        System.Console.WriteLine("Before starting your list you must first register with us.");
        string fullName = GetAndValidateUserInput("Full Name", 4, 20);  // this is not working right for full name due to space - need to figure out
        System.Console.WriteLine();
        System.Console.WriteLine(($"Welcome {fullName} "));
        System.Console.WriteLine();
        //Method to get User Name
        string userName = GetAndValidateUserInput("Username", 7, 10);
        System.Console.WriteLine();
        //Method to get Password
        string password = GetAndValidateUserInput("Password", 5, 10);   //not working as expected - cant do numbers right now - need to fix?
        System.Console.WriteLine();
        //Method to create RegisterUser with full name, user name, and password - pulls from above
        User user = RegisterUser(fullName, userName, password);
        //other stuff

        //Need to add Login Stuff


        
        //Display Main menu
       
        bool exitRequested = false;

        while (!exitRequested)
        {
            int selection = DisplayMainMenuAndGetSelection();
            
            switch (selection)
            {
                case 1:
                    DisplayAddTaskMenu(user);
                    break;
                case 2:
                    DisplayAllTasks(user);
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

        TaskListStorage = new TaskListStorage();

        UserRepo userRepo = new UserRepo(appStorage);
        TaskRepo taskRepo = new TaskRepo(appStorage);

    }    
        
}



