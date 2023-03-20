namespace RH_App.Views;

public partial class BiograpgyPage : ContentPage
{
	public BiograpgyPage(BiograpgyViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
