namespace TaskPlanner.Core.UseCases.CreateTodo;

public record CreateTodoCommand : IRequest
{
    public CreateTodoCommand(string Title, string Description)
    {
        this.Title = Title;
        this.Description = Description;
    }

    public string Title { get; init; }
    public string Description { get; init; }

    public void Deconstruct(out string Title, out string Description)
    {
        Title = this.Title;
        Description = this.Description;
    }
}