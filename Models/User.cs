using Microsoft.EntityFrameworkCore;

[Index(nameof(UserName), IsUnique = true)]  //Setting unique index on UserName / EF
class User
{
    //Properties
    public int Id { get; set;}
    public string Name { get; set;}
    public string UserName { get; set;}  
    public string Password { get; private set;}
    public List<Todo> Todos { get; set; } = new List<Todo>(); //EF give list of ToDos on User - EF uses reflection
    
   //Constructors
    public User(string name, string userName, string password) // new object of User
    {
        Name = name;
        UserName = userName;
        Password = password;
    }

    //ToString - not being used currently
    public override string ToString()
    {
        string str = "";
        str += "Thank You " + Name;
        str += ".";
        str += "It is time to start creating your list.";
        
        return str;
    }
}
