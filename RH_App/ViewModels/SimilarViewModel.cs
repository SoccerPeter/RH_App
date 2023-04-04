namespace RH_App.ViewModels;
public partial class SimilarViewModel : BaseViewModel
{
	readonly ArtistService dataService;

	[ObservableProperty]
	bool isLoading;

	[ObservableProperty]
	ObservableCollection<SimilarArtists> items;

	public SimilarViewModel(ArtistService service)
	{
		dataService = service;
	}


	public async Task LoadDataAsync()
	{
        if (CurrentArtist.Name == null) { return; }
        IsLoading = true;
        Items = new ObservableCollection<SimilarArtists>(await dataService.GetSimilarArtists(CurrentArtist.Name));
        IsLoading = false;
    }
}
