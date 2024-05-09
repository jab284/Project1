class Task
{
    //put task stuff here
    private int id;
    public int clientId;
    public string message = "";



     //Constructor
    public Task(string Message, int ClientId)
    {
       
        ClientId = clientId;
        Message = message;
    }

    //ToString -need to add ******
    /*public override string ToString()
    {
        toString will go here
             
    }*/
}