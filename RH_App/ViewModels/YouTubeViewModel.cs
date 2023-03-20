using RH_App.Models.Spotify;
using RH_App.ViewModels.Views;

namespace RH_App.ViewModels;

public partial class YouTubeViewModel : BaseViewModel {
    readonly ArtistService dataService;

    [ObservableProperty]
    ObservableCollection<SpotifyArtist> items;

    [ObservableProperty]
    bool isLoading;

    public SpotifyArtist SelectedAlbum { get; set; }

    public YouTubeViewModel(ArtistService service) {
        dataService = service;
    }

    public async Task LoadDataAsync() {
        if (CurrentArtist.Name == null) { return; }
        //if ((bool)CurrentArtist.Update)
        //{
            IsLoading = true;
            Items = new ObservableCollection<SpotifyArtist>(await dataService.GetSpotifyArtists(CurrentArtist.Name));
            IsLoading = false;
        //}
    }

    [RelayCommand]
    private async void GoToDetails(SpotifyArtist item) {
        CurrentArtist.Update = false;
        await Shell.Current.GoToAsync(nameof(YoutubeDtetailsPagePage), true, new Dictionary<string, object>
        {
            { "Item", item }
        });
    }
}   