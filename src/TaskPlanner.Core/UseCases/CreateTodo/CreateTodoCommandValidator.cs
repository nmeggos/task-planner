namespace TaskPlanner.Core.UseCases.CreateTodo;

public class CreateTodoCommandValidator : AbstractValidator<CreateTodoCommand>
{
    public CreateTodoCommandValidator()
    {
        RuleFor(t => t.Title)
            .NotEmpty()
            .NotNull();

        RuleFor(d => d.Description)
            .NotEmpty()
            .NotNull();
    }
}