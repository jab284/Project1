using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class User
{
    public string Name { get; set;}
    private string UserName { get; set;}  
    private string Password { get; set;}
    public List<string> TaskList { get; set;}
    





    
   //Constructors
    public User(string fullName, string userName, string password)
    {
        Name = fullName;
        UserName = userName;
        Password = password;
        TaskList = new List<string>();
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

    //Add Task Method
    public void AddTask()
    {
        System.Console.WriteLine("What task would you like add?"); 
        string input  = Console.ReadLine();
        System.Console.WriteLine();
        TaskList.Add(input);
        System.Console.WriteLine($"Task '{input}' was added to your list.");
        System.Console.WriteLine();
    }
}


