using Project1.Util;

class UserRepo
{
    private TodoListContext _todoListContext;

    public UserRepo(TodoListContext todoListContext)
    {
        this._todoListContext = todoListContext;
    }

    //Add User
    public User AddUser(User user)
    {
        _todoListContext.Users.Add(user);
        _todoListContext.SaveChanges();
        
        return user;
    }

    //Get user by Username
    public User GetUserByUsername(string username)
    {
        return _todoListContext
            .Users
            .Where(user => user.UserName == username)
            .Single();
    }
}
