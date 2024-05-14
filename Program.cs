class Program
{
    //METHODS
    static string GetAndValidateUserInput(string inputName, int minLength, int maxLength)
    {
        //While Loop
        while (true)
        {
            //format strings for registering name            
            System.Console.WriteLine(
            $"Please enter your {inputName}. It must be between {minLength} and {maxLength} alpha characters long."); //take out??
            string? input = Console.ReadLine(); //reads input from user
            try //Exceptions --  for wrong length
            {
                if (input.Length > maxLength || input.Length < minLength)
                {
                    throw new IndexOutOfRangeException(
                        $"Input must be between {minLength} and {maxLength} alpha characters long.");
                }

                for (int i = 0; i < input.Length; i++)

                {
                    if (!char.IsLetter(input[i])) //invalid character exception
                    {
                        throw new FormatException("Input must only be alpha characters.");
                    }
                }

                // return to break out of while loop
                return input; //users input
            }
            catch (IndexOutOfRangeException)
            {
                System.Console.WriteLine(
                    $"Your {inputName} must be between {minLength} and {maxLength} alpha characters long.");
                System.Console.WriteLine("Please try again.");
            }
            catch (FormatException)
            {
                System.Console.WriteLine($"Your {inputName} must only be alpha characters");
                System.Console.WriteLine("Please try again.");
            }
        }
    }

    //Method to Display main menu and make selection
    static int DisplayMainMenuAndGetSelection()
    {
        while (true)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("TASK MENU:");
            System.Console.WriteLine("What would you like to do next?");
            System.Console.WriteLine();
            System.Console.WriteLine("[1] Add a new ToDo task");
            System.Console.WriteLine("[2] View all ToDo tasks");  //changed spelling - added apostrophe
            System.Console.WriteLine("[3] Exit");
            System.Console.WriteLine();
            System.Console.WriteLine("Please select an option:");

            string? input = Console.ReadLine(); //returns users input for selection
            System.Console.WriteLine();
            try
            {
                int selection = int.Parse(input); //turn user input into int
                if (selection < 1 || selection > 3)
                {
                    throw new IndexOutOfRangeException("Selection must be between 1 and 3.");
                }

                return selection;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Sorry!  Your selection is invalid.");
                System.Console.WriteLine("Selection must be between 1 and 3.  Please try again.");
                System.Console.WriteLine();
            }
        }
    }

    //Method Display Add Todo Menu
    static void DisplayAddTodoMenu(TodoService todoService, User activeUser)
    {
        System.Console.WriteLine("What todo would you like add?");
        string? input = Console.ReadLine();
        System.Console.WriteLine();

        Todo todo = todoService.AddTodo(input, activeUser);

        System.Console.WriteLine($"ToDo Task '{input.ToUpper()}' was added to your list.");
        System.Console.WriteLine();
    }

    //Method Display All Todos
    static void DisplayAllTodosMenu(TodoService todoService, User activeUser)
    {
        System.Console.WriteLine("YOUR LIST OF TODO TASKS:");
        System.Console.WriteLine();
        List<Todo> todos = todoService.GetAllTodos(activeUser);
        foreach (Todo todo in todos)
        {
            System.Console.WriteLine(todo);
        }

        System.Console.WriteLine();
        System.Console.WriteLine();
    }

    // Method to Display Register User Menu
    static User DisplayRegisterUserMenu(UserService userService)
    {
        //System.Console.WriteLine("----------"); //maybe wrong spot
        System.Console.WriteLine("REGISTER:");
        //Method to get First Name
        System.Console.WriteLine("Before creating your list you must first register with us.");
        System.Console.WriteLine("After registering with us, you will need to Login.");
        System.Console.WriteLine();
        string
            firstName = GetAndValidateUserInput("First Name", 4,
                20); // this is not working right for first name due to space - need to figure out
        System.Console.WriteLine();
        System.Console.WriteLine(($"Welcome {firstName}!"));
        System.Console.WriteLine();
        //Method to get User Name
        string userName = GetAndValidateUserInput("Username", 7, 10);
        System.Console.WriteLine();
        //Method to get Password
        string
            password = GetAndValidateUserInput("Password", 5, 10); //not working as expected - cant do numbers right now - need to fix?
        System.Console.WriteLine();
        //Method to create RegisterUser with first name, user name, and password - pulls from above
        User user = userService.RegisterUser(firstName, userName, password);
        return user;
    }

    // Method to Display Login Menu
    static User DisplayLoginMenu(UserService userService)
    {
        // Login - Menu name - UserName - Password - Success - return
        System.Console.WriteLine("Welcome Back! ");
        System.Console.WriteLine();
        System.Console.WriteLine("LOGIN MENU:");
        System.Console.WriteLine();
        string userName = GetAndValidateUserInput("Username", 7, 10);
        System.Console.WriteLine();
        string password = GetAndValidateUserInput("Password", 5, 10);
        System.Console.WriteLine();
        User user = userService.Login(userName, password);
        //System.Console.WriteLine();
        return user;
    }
    
    // Method to Display Entry Main Menu
    static int DisplayEntryMainMenu()
    {
        while (true)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("MAIN MENU");
            System.Console.WriteLine();
            System.Console.WriteLine("Please Register or Login:");
            System.Console.WriteLine();
            System.Console.WriteLine("[1] Register");
            System.Console.WriteLine("[2] Login");
            System.Console.WriteLine("[3] Exit");
            System.Console.WriteLine();
            System.Console.WriteLine("Please select an option:");

            string? input = Console.ReadLine(); //returns users input for selection
            System.Console.WriteLine(); ///do i want to add line
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine();
            try
            {
                int selection = int.Parse(input); //turn user input into int
                if (selection < 1 || selection > 3)
                {
                    throw new IndexOutOfRangeException("Selection must be between 1 and 3.");
                }

                return selection;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Sorry!  Your selection is invalid.");
                System.Console.WriteLine("Selection must be between 1 and 3.  Please try again.");
                System.Console.WriteLine();
            }
            System.Console.WriteLine("-----------------------------------------------------");
            System.Console.WriteLine();
        }
       
    }
    
    

    //This is the MAIN --------------------------------------------
    static void Main(string[] args)

    {
        // App setup
        TodoListStorage appStorage = new TodoListStorage();
        UserRepo userRepo = new UserRepo(appStorage);
        TodoRepo todoRepo = new TodoRepo(appStorage);
        UserService userService = new UserService(userRepo);
        TodoService todoService = new TodoService(todoRepo);

        System.Console.WriteLine();
        System.Console.WriteLine("       Welcome to: ");
        System.Console.WriteLine();
        System.Console.WriteLine("**************************");
        System.Console.WriteLine("* CREATE YOUR TO DO LIST * ");
        System.Console.WriteLine("**************************");
        System.Console.WriteLine();
        System.Console.WriteLine("Here, you can easily maintain and track your list of need to do chores!");
        System.Console.WriteLine();
        System.Console.WriteLine("--------------------------");
        //System.Console.WriteLine();

        User? user = null;  

        //Display Entry Menu ******
        bool exitRequested = false;
        bool loggedIn = false;
        while (!(exitRequested || loggedIn))
        {
            
            int selection = DisplayEntryMainMenu();
            switch (selection)
            {
                case 1:
                    DisplayRegisterUserMenu(userService);
                    break;
                case 2:
                    try
                    {
                        user = DisplayLoginMenu(userService);
                        loggedIn = true;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Could not login. Username or password is incorrect.");
                    }
                    break;
                case 3:
                    System.Console.WriteLine("Have a great day.  See you later!");
                    System.Console.WriteLine();
                    exitRequested = true;
                    break;
                default:
                    System.Console.WriteLine("Invalid selection.  Please select, 1, 2, or 3.");
                    break;
            }
            Console.WriteLine("--------------------------------");
        }

        if (exitRequested)
        {
            return;
        }
        
        //Display ToDo Task Main menu
        exitRequested = false;
        while (!exitRequested)
        {
            int selection = DisplayMainMenuAndGetSelection();

            switch (selection)
            {
                case 1:
                    DisplayAddTodoMenu(todoService, user);
                    break;
                case 2:
                    DisplayAllTodosMenu(todoService, user);
                    break;
                case 3:
                    System.Console.WriteLine("Have a great day.  See you later!");
                    exitRequested = true;
                    System.Console.WriteLine(); 
                    break;
                default:
                    System.Console.WriteLine("Invalid selection.  Please select, 1, 2, or 3.");
                    break;
            }
            Console.WriteLine("--------------------------------");
        }
    }
}
