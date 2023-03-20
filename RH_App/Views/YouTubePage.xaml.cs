namespace RH_App.Views;

public partial class YouTubePage : ContentPage
{
	YouTubeViewModel ViewModel;
    public YouTubePage(YouTubeViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = ViewModel = viewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args) {
        base.OnNavigatedTo(args);

        await ViewModel.LoadDataAsync();
    }
}
