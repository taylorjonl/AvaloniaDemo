namespace AvaloniaDemo.Contracts.DependencyInjection;

public interface IDependencyResolver
{
    T Create<T>() where T : notnull;
    T Get<T>() where T : notnull;
    T GetOrCreate<T>() where T : notnull;
}
