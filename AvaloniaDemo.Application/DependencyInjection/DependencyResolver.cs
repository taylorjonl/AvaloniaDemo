using AvaloniaDemo.Contracts.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaDemo.Application.DependencyInjection;

public class DependencyResolver : IDependencyResolver
{
    private readonly IServiceProvider serviceProvider;

    public DependencyResolver(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public T Create<T>()
        where T : notnull
    {
        return ActivatorUtilities.CreateInstance<T>(this.serviceProvider);
    }

    public T Get<T>()
        where T : notnull
    {
        return this.serviceProvider.GetRequiredService<T>();
    }

    public T GetOrCreate<T>()
        where T : notnull
    {
        return ActivatorUtilities.GetServiceOrCreateInstance<T>(this.serviceProvider);
    }
}
