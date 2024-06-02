using Project1.Util;

class TodoRepo
{
    //Field - depends on database context
    private TodoListContext _todoListContext;
    
    //Constructor - setting the dependency
    public TodoRepo(TodoListContext todoListContext)
    {
        this._todoListContext = todoListContext;
    }

    //Add task to user
    public Todo AddTodo(Todo todo)
    {
        _todoListContext.Todos.Add(todo); //lets us talk to DB / Insert statement
        _todoListContext.SaveChanges();

        return todo;
    }

    //Get All todos by userid
    public List<Todo> GetAllTodosByUserId(int userId)
    {
        return _todoListContext
            .Todos
            .Where(todo => todo.UserId == userId)  //Select statement
            .ToList();
    }
}
