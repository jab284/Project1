class UserRepo
{
    private TodoListStorage _todoListStorage;

    public UserRepo(TodoListStorage todoListStorage)
    {
        this._todoListStorage = todoListStorage;
    }

    //Add User
    public User AddUser(User user)
    {
        user.Id = _todoListStorage.userIdCounter;
        _todoListStorage.userIdCounter++;
        
        //Add to user table
        _todoListStorage.UserTable.Add(user.Id, user);
        
        return user;
    }

    //Get user by Username
    public User GetUserByUsername(string username)
    {
        //Get user from user table by username
        foreach (User user in _todoListStorage.UserTable.Values)
        {
            if (user.UserName == username)
            {
                return user;
            }
        }
        throw new ArgumentException("User not found");
    }
}
