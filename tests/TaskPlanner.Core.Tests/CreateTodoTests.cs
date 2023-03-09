namespace TaskPlanner.Core.Tests;

public class CreateTaskTests
{
    [Fact]
    public void WhenCreatingTodo_ShouldHaveRequiredFields()
    {
        var sut = Todo.Create("SomeTitle", "SomeDescription");

        sut.Should().NotBeNull();

        sut.Id
            .Should()
            .NotBeNull().And
            .BeOfType<TodoId>();

        sut.Title
            .Should()
            .NotBeNull()
            .And
            .NotBeNull();
        
        sut.Description
            .Should()
            .NotBeNull()
            .And
            .NotBeNull();
    }
}