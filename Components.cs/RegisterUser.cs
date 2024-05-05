class RegisterUser
{
    public string fullName;
    private string userName;
    private string password;
    public int clientID;


    

   


    //Constructor
    private RegisterUser()
    {
        
    }

    public RegisterUser(string fullName)
    {
        //string fullName= fullName;    take out?
    }

    private RegisterUser(string fullName, string userName, string password, int clientID)
    {
        this.fullName = fullName;
        this.userName = userName;
        this.password = password;
        this.clientID = clientID;
    }

}