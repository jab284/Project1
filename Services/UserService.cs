class UserService
{
    //Field
    private UserRepo userRepo;
    
    //Constructor - dependency - creates a new service object
    public UserService(UserRepo userRepo)
    {
        this.userRepo = userRepo;
    }

    //Register the user
    public User RegisterUser(string firstName, string userName, string password)
    {
        User user = new User(firstName, userName, password);
        user = userRepo.AddUser(user);  //making new user and asking repo to save it
        return user;
    }
    
    //Login the user
    public User Login(string userName, string inputPassword)
    {
        User user = userRepo.GetUserByUsername(userName); // pulling user object from repo

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
