class UserService
{
    private UserRepo userRepo;
    
    public UserService(UserRepo userRepo)
    {
        this.userRepo = userRepo;
    }

    public User RegisterUser(string fullName, string userName, string password)
    {
        User user = new User(fullName, userName, password);
        user = userRepo.AddUser(user);
        return user;
    }
    
    public User Login(string userName, string inputPassword)
    {
        User user = userRepo.GetUserByUsername(userName);

        if (inputPassword == user.Password)
        {
            return user;
        }
        else
        {
            throw new ArgumentException("Password is incorrect");
        }
    }
}
