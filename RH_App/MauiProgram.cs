using RH_App.ViewModels.ViewModels;
using RH_App.ViewModels.Views;
using RH_App.Views;

namespace RH_App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMediaElement()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<BiograpgyViewModel>();

		builder.Services.AddSingleton<BiograpgyPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<DiscographyDetailViewModel>();
		builder.Services.AddTransient<DiscographyDetailPage>();

		builder.Services.AddSingleton<DiscographyViewModel>();

		builder.Services.AddSingleton<DiscographyPage>();

		builder.Services.AddTransient<SampleDataService>();
        builder.Services.AddTransient<ArtistService>();

		builder.Services.AddSingleton<SimilarViewModel>();

		builder.Services.AddSingleton<SimilarPage>();

		builder.Services.AddSingleton<GalleryViewModel>();

		builder.Services.AddSingleton<GalleryPage>();

		builder.Services.AddSingleton<YouTubeViewModel>();
        builder.Services.AddSingleton<YoutubeDtetailsPageViewModel>();

        builder.Services.AddSingleton<YouTubePage>();
        builder.Services.AddSingleton<YoutubeDtetailsPagePage>();

        builder.Services.AddSingleton(AudioManager.Current);

		return builder.Build();
	}
}
