class TodoService
{
    private TodoRepo _todoRepo;
    
    public TodoService(TodoRepo todoRepo)
    {
        this._todoRepo = todoRepo;
    }

    public Todo AddTodo(string description, User user)
    {
        Todo todo = new Todo(description, user.Id);
        _todoRepo.AddTodo(todo);
        
        return todo;
    }
    
    public List<Todo> GetAllTodos(User user)
    {
        return _todoRepo.GetAllTodosByUserId(user.Id);
    }
}
