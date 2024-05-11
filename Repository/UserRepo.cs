class UserRepo
{
    private TaskListStorage taskListStorage;

    public UserRepo(TaskListStorage taskListStorage)
    {
        this.taskListStorage = taskListStorage;
    }







    //Add User
    public User AddUser(User user)
    {
        //Add to user table
        taskListStorage.UserTable.Add(user.Id, user);
        taskListStorage.userIdCounter++;
    }

    //Get user by Username
    public User GetUserByUsername(string username)
    {
        //Get user from user table by username
        foreach (User user in taskListStorage.UserTable.Values)
        {
            if (user.Username == username)
            {
                return user;
            }
        }
        throw new Exception("User not found");
    }
}