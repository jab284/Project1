class TodoService
{
    //Field
    private TodoRepo _todoRepo;
    
    //Constructor - dependency - creates a new service object
    public TodoService(TodoRepo todoRepo)
    {
        this._todoRepo = todoRepo;
    }

    //Add a task
    public Todo AddTodo(string description, User user)
    {
        Todo todo = new Todo(description, user.Id);
        _todoRepo.AddTodo(todo); //insert new todo - repo talking to the database
        
        return todo;
    }
    
    //Get all of the tasks
    public List<Todo> GetAllTodos(User user)
    {
        return _todoRepo.GetAllTodosByUserId(user.Id);
    }
}
