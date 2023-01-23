using AvaloniaDemo.Application.DependencyInjection;
using AvaloniaDemo.Contracts.DependencyInjection;
using AvaloniaDemo.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AvaloniaDemo.Application
{
    public class Bootstrapper
    {
        public IDependencyResolver? DependencyResolver { get; private set; }

        public void Run()
        {
            var builder = Host.CreateApplicationBuilder();

            builder.Services.AddSingleton<MainWindowModel>();

            var host = builder.Build();

            this.DependencyResolver = new DependencyResolver(host.Services);
        }
    }
}
