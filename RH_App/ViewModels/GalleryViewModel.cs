namespace RH_App.ViewModels;

public partial class GalleryViewModel : BaseViewModel
{
    readonly ArtistService dataService;

    [ObservableProperty]
    public ObservableCollection<Bilder> items;

    [ObservableProperty]
    bool isLoading;

    public GalleryViewModel(ArtistService service) 
    {
        dataService = service;
    }


    public async Task LoadDataAsync() {
        try {
            IsLoading = true;
            Items = new ObservableCollection<Bilder>(await dataService.GetArtistPhoto(CurrentArtist.Name));
        }
        catch (Exception ex) {
            throw new NotImplementedException();
        }
        finally {
            IsLoading = false;
        }
    }
}
