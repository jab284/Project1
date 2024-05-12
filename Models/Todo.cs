class Todo
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; } = "";
    
     //Constructor
    public Todo(string description, int userId)
    {
        this.UserId = userId;
        this.Description = description;
    }

    public override string ToString()
    {
        return $"Todo: {Description}";  
    }
}
