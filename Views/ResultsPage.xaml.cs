using CaicedoRamos_Progreso3.Models;
using CaicedoRamos_Progreso3.ViewModels;
using Microsoft.Maui.Controls;

namespace CaicedoRamos_Progreso3.Views
{
    public partial class ResultsPage : ContentPage
    {
        private readonly ResultsPageViewModel _viewModel;

        public ResultsPage(AC_Artist.Root artistData)
        {
            InitializeComponent();
            _viewModel = new ResultsPageViewModel { ArtistData = artistData };
            BindingContext = _viewModel;
        }
    }
}
