using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class User
{
    public string Name { get; set;}
    private string UserName { get; set;}  
    private string Password { get; set;}
    public List<string> taskList { get; set;}
    public bool addAnother = true;





    //Method - should be on programs page
    /*public static void EnterCredentials()
    {
    System.Console.WriteLine("Welcome back");
    System.Console.WriteLine("Please enter your User Name.");
    Console.ReadLine();
    System.Console.WriteLine("Please enter your password");
    Console.ReadLine();
    }
    */





    //Constructors
    private User()
    {

    }
    public User(string fullName)
    {
        Name = fullName;
    }

    private User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
    public User(string fullName, string userName, string password)
    {
        Name = fullName;
        UserName = userName;
        Password = password;
    }

   
    //ToString
    public override string ToString()
    {
        string str = "";
        str += "Thank You " + Name;
        str += ".";
        str += "It is time to start creating your list.";
        
        return str;
        
    }

   
    public void AddTask()
    {
        do
        {
            System.Console.WriteLine("What task would you like add?"); 
            Console.ReadLine();
            System.Console.WriteLine("Would you like to add another task?  Please select Y or N.");
            Console.ReadLine();
        }  
        while (addAnother == true) ; 
    }




}


