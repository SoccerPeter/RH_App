namespace RH_App.Views;

public partial class DiscographyDetailPage : ContentPage
{
	public DiscographyDetailPage(DiscographyDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
