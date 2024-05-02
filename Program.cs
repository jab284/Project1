using System;

class Program
{
    static void Main(string[] args)
    {
        
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














    }
}