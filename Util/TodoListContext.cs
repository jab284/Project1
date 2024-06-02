using Microsoft.EntityFrameworkCore;

namespace Project1.Util;

class TodoListContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Todo> Todos { get; set; }

    private string ConfigurationString { get; }

    public TodoListContext()
    {
        ConfigurationString = File.ReadAllText(@"C:\Revature\DBConnections\JenAToDoListApp.txt"); // todo: get your file path and place it here
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(ConfigurationString);
    }
}
