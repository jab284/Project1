using Microsoft.EntityFrameworkCore;

[Index(nameof(UserName), IsUnique = true)]
class User
{
    //Properties
    public int Id { get; set;}
    public string Name { get; set;}
    public string UserName { get; set;}  
    public string Password { get; private set;}
    public List<Todo> Todos { get; set; } = new List<Todo>();
    
   //Constructors
    public User(string name, string userName, string password)
    {
        Name = name;
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
}
