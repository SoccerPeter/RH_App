using RH_App.Models.TopAlbums;

namespace RH_App.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class DiscographyDetailViewModel : BaseViewModel
{
    readonly ArtistService dataService;

    [ObservableProperty]
    ObservableCollection<TopAlbums> items;


    [ObservableProperty]
    TopAlbums item;

    [ObservableProperty]
    bool isLoading;

    public DiscographyDetailViewModel(ArtistService service)
    {
        dataService = service;
    }
}
