using RH_App.ViewModels.Views;

namespace RH_App;

public partial class AppShell : Shell {
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DiscographyDetailPage), typeof(DiscographyDetailPage));
        Routing.RegisterRoute(nameof(YoutubeDtetailsPagePage), typeof(YoutubeDtetailsPagePage));
        BindingContext = new ViewModelAppShell();
    }
}
