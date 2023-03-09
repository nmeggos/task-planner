namespace TaskPlanner.ArchitecturalTests;

public class AssemblyReferenceTests
{
    [Fact]
    public void Core_ShouldNotReference_OtherAssemblies()
    {
        var coreAssembly = typeof(Core.AssemblyReference).Assembly;

        coreAssembly.Should().NotReference(typeof(API.AssemblyReference).Assembly);
        coreAssembly.Should().NotReference(typeof(Infrastructure.AssemblyReference).Assembly);
    }
}