using Microsoft.Toolkit.Mvvm.Input;
using CaicedoRamos_Progreso3.Models;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace CaicedoRamos_Progreso3.ViewModels
{
    public class SearchPageViewModel : ObservableObject
    {
        private readonly ApiCaller _apiCaller = new ApiCaller();
        private string _artistName;
        private AC_Artist.Root _artistData;

        public string ArtistName
        {
            get => _artistName;
            set => SetProperty(ref _artistName, value);
        }

        public AC_Artist.Root ArtistData
        {
            get => _artistData;
            set => SetProperty(ref _artistData, value);
        }

        public IAsyncRelayCommand SearchCommand { get; }

        public SearchPageViewModel()
        {
            SearchCommand = new AsyncRelayCommand(SearchArtistAsync);
        }

        private async Task SearchArtistAsync()
        {
            ArtistData = await _apiCaller.GetArtistData(ArtistName);
        }
    }
}
