using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaDemo.Application;
using AvaloniaDemo.Pages;
using AvaloniaDemo.ViewModels;

namespace AvaloniaDemo;

public partial class App : Avalonia.Application
{
    private readonly Bootstrapper bootstrapper = new Bootstrapper();

    public override void Initialize()
    {
        this.bootstrapper.Run();

        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = this.bootstrapper.DependencyResolver!.Get<MainWindowModel>(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}