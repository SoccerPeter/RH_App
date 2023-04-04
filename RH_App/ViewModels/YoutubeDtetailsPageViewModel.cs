namespace RH_App.ViewModels.ViewModels
{
    [QueryProperty(nameof(Item), "Item")]

    public partial class YoutubeDtetailsPageViewModel : BaseViewModel
    {
        readonly ArtistService dataService;

        [ObservableProperty]
        ObservableCollection<SpotifyAlbum> itemTracks;

        [ObservableProperty]
        SpotifyArtist item;

        [ObservableProperty]
        bool isLoading;

        public YoutubeDtetailsPageViewModel(ArtistService service)
        {
            dataService = service;
        }

        public async Task LoadTracksAsync()
        {
            if (CurrentArtist.Name == null) { return; }
            IsLoading = true;
            ItemTracks = new ObservableCollection<SpotifyAlbum>(await dataService.GetSpotifyAlbums(item.AlbumId));
            IsLoading = false;
        }
    }

    
}
