namespace TaskPlanner.Core.Domain;

public class Todo
{
    private Todo()
    {
    }
    
    private Todo(TodoId id, string title, string description)
    {
        Title = title;
        Description = description;
        Id = id;
    }

    public TodoId Id { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public DateTime? DueOne { get; private set; }

    public static Todo Create(string title, string description)
    {
        return new Todo(new TodoId(Guid.NewGuid()), title, description);
    }
}