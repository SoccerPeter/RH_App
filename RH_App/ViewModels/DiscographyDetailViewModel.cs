namespace RH_App.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class DiscographyDetailViewModel : BaseViewModel
{
    readonly ArtistService dataService;

    [ObservableProperty]
    ObservableCollection<Albums> items;


    [ObservableProperty]
	Albums item;

    [ObservableProperty]
    bool isLoading;

    public DiscographyDetailViewModel(ArtistService service)
    {
        dataService = service;
    }
}
