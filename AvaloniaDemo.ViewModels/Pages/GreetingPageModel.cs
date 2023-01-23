using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaDemo.ViewModels.Pages;

public partial class GreetingPageModel : ObservableObject
{
    [ObservableProperty]
    private string greeting = "Welcome to Avalonia!";
}
