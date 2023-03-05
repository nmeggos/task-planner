using TaskPlanner.Core.Domain;

namespace TaskPlanner.Core.UseCases.CreateTodo;

public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand>
{
    public async Task Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        var todo = Todo.Create(request.Title, request.Description);

        await Task.CompletedTask;
    }
}