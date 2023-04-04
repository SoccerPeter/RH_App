namespace RH_App.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    public bool isBusy;

    [ObservableProperty]
    public bool tabIsEnabled;
}
