using Microsoft.Toolkit.Mvvm.ComponentModel;
using CaicedoRamos_Progreso3.Models;

namespace CaicedoRamos_Progreso3.ViewModels
{
    public class ResultsPageViewModel : ObservableObject
    {
        private AC_Artist.Root _artistData;

        public AC_Artist.Root ArtistData
        {
            get => _artistData;
            set => SetProperty(ref _artistData, value);
        }
    }

}
