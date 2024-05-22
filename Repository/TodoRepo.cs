using Project1.Util;

class TodoRepo
{
    private TodoListContext _todoListContext;
    
    public TodoRepo(TodoListContext todoListContext)
    {
        this._todoListContext = todoListContext;
    }

    //Add task to user
    public Todo AddTodo(Todo todo)
    {
        _todoListContext.Todos.Add(todo);
        _todoListContext.SaveChanges();

        return todo;
    }

    //Get All todos by userid
    public List<Todo> GetAllTodosByUserId(int userId)
    {
        return _todoListContext
            .Todos
            .Where(todo => todo.UserId == userId)
            .ToList();
    }
}
