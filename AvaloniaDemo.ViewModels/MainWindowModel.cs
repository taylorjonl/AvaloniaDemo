using AvaloniaDemo.ViewModels.Pages;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaDemo.ViewModels;

public partial class MainWindowModel : ViewModelBase
{
    [ObservableProperty]
    private object content = new GreetingPageModel();
}
