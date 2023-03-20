namespace RH_App.Views;

public partial class GalleryPage : ContentPage
{
    GalleryViewModel ViewModel;
    public GalleryPage(GalleryViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = ViewModel = viewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args) {
        base.OnNavigatedTo(args);

        await ViewModel.LoadDataAsync();
    }
}
