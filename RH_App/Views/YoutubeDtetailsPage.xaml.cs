using RH_App.ViewModels.ViewModels;
using System.Threading.Tasks;

namespace RH_App.ViewModels.Views
{
    public partial class YoutubeDtetailsPagePage : ContentPage
    {
        YoutubeDtetailsPageViewModel ViewModel;
        public YoutubeDtetailsPagePage(YoutubeDtetailsPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = ViewModel = viewModel;
        }
        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            await ViewModel.LoadTracksAsync();
        }
    }
}
