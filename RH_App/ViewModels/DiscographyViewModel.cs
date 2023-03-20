namespace RH_App.ViewModels;

public partial class DiscographyViewModel : BaseViewModel 
{
	readonly ArtistService dataService;

    [ObservableProperty]
	ObservableCollection<Albums> items;

    [ObservableProperty]
    bool isLoading;

    public DiscographyViewModel(ArtistService service)
	{
		dataService = service;
	}

	public async Task LoadDataAsync()
	{
		if (CurrentArtist.Name == null) { return; }
		if ((bool)CurrentArtist.Update) {
            IsLoading = true;
            Items = new ObservableCollection<Albums>(await dataService.GetTopAlbums(CurrentArtist.Name));
            IsLoading = false;
        }
    }


	[RelayCommand]
	private async void GoToDetails(Albums item)
	{
		CurrentArtist.Update = false;

        await Shell.Current.GoToAsync(nameof(DiscographyDetailPage), true, new Dictionary<string, object>
		{
			{ "Item", item }
		}); ;
	}
}
