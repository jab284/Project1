class TaskListStorage
{
     public Dictionary<int, User> UserTable;
    public Dictionary<int, Task> TaskTable;
    public int userIdCounter = 1;
    public int taqskIdCounter = 1;
    





    //Constructor
    public TaskListStorage()
    {
        UserTable = new(); userIdCounter++;
        TaskTable = new(); taqskIdCounter++;
    }
   
    
}