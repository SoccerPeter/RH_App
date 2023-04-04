namespace RH_App.Views;

public partial class SimilarPage : ContentPage
{
	SimilarViewModel ViewModel;

	public SimilarPage(SimilarViewModel viewModel)
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
