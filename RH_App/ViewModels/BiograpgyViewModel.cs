using RH_App.Models;
using RH_App.Services;

namespace RH_App.ViewModels;

public partial class BiograpgyViewModel : BaseViewModel
{
    private readonly ArtistService artistService;
    public ObservableCollection<Result> Artists { get; private set; } = new();

    public BiograpgyViewModel(ArtistService artistService) {
        this.artistService = artistService;
    }

    [ObservableProperty]
    bool isLoading;

    [RelayCommand]
    async Task GetArtistCommand(string artist) {
        try {
            IsLoading = true;
            if (Artists.Any())
            {
                Artists.Clear();
            }

            CurrentArtist.Update = true;
            var Gruop = await artistService.GetArtist(artist);
            Artists.Add(Gruop.result);
            CurrentArtist.Name = artist;
            CurrentArtist.ArtistId = Artists[0].idArtist;
        }
        catch (Exception ex) {
            throw new NotImplementedException();
        }
        finally {
            IsLoading = false;
        }
    }

}
