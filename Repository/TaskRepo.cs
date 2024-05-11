class TaskRepo
{
    private TaskListStorage taskListStorage;





    public TaskRepo(TaskListStorage taskListStorage)
    {
        this.taskListStorage = taskListStorage;
    }

    //Add task to user
    public Task AddTask(Task task)
    {
        taskListStorage.TaskTable.Add(task.clientId, task);
    }

    //Get All tasks by userid
    public List<Task> GetAllTasksByUserId(int userId)
    {
        //Get user from user table by user id
        //Get tasks from user
        List<Task> tasks = new();
        foreach (Task task in taskListStorage.TaskTable.Values)
        {
            if (task.userId == userId)
            {
                tasks.Add(task);
            }
        }
        return tasks;
    }
}