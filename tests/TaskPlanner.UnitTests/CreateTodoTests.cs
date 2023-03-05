using FluentAssertions;
using TaskPlanner.Core.Domain;

namespace TaskPlanner.UnitTests;

public class CreateTaskTests
{
    [Fact]
    public void WhenCreatingTodo_ShouldHaveRequiredFields()
    {
        var sut = Todo.Create("SomeTitle", "SomeDescription");

        sut.Should().NotBeNull();
        
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