class TodoController
{
    //Field
    private TodoService _todoService;  //Depends on the service
    
    //Constructor
    public TodoController(TodoService todoService)  //passing dependency in to create the controller
    {
        this._todoService = todoService;
    }

    //Method - calls the service method
    public Todo AddTodo(string description, User user)
    {
        Todo todo = _todoService.AddTodo(description, user);
        return todo;
    }

    //Method - calls the service method
    public List<Todo> GetAllTodos(User user)
    {
        return _todoService.GetAllTodos(user);
    }
}

