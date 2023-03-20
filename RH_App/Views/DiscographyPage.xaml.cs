namespace RH_App.Views;

public partial class DiscographyPage : ContentPage
{
	DiscographyViewModel ViewModel;

	public DiscographyPage(DiscographyViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
}
