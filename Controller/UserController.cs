class UserController
{
    //Field
    private UserService userService;
    
    //Constructor - settinguser service dependency
    public UserController(UserService userService)
    {
        this.userService = userService;
    }

    //Method - calls the service method
    public User RegisterUser(string firstName, string userName, string password)
    {
        User user = userService.RegisterUser(firstName, userName, password);
        return user;
    }

    //Method - calls the service method
    public User Login(string userName, string inputPassword)
    {
        User user = userService.Login(userName, inputPassword);
        return user;
    }
}
