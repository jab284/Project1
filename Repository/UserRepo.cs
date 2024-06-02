using Project1.Util;

class UserRepo
{
    //Field - depends on database context
    private TodoListContext _todoListContext;

    //Constructor - setting the dependency
    public UserRepo(TodoListContext todoListContext)
    {
        this._todoListContext = todoListContext;
    }

    //Add User
    public User AddUser(User user)
    {
        _todoListContext.Users.Add(user);  //Insert statement
        _todoListContext.SaveChanges();
        
        return user;
    }

    //Get user by Username
    public User GetUserByUsername(string username)
    {
        return _todoListContext
            .Users
            .Where(user => user.UserName == username) //Select statement
            .Single();  //due to unique index so only get one back
    }
}
