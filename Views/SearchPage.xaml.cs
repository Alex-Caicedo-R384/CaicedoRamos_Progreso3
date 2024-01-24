using CaicedoRamos_Progreso3.Models;
using CaicedoRamos_Progreso3.ViewModels;
using System;
using Microsoft.Maui.Controls;

namespace CaicedoRamos_Progreso3.Views
{
    public partial class SearchPage : ContentPage
    {
        private readonly SearchPageViewModel _viewModel = new SearchPageViewModel();

        public SearchPage()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            await _viewModel.SearchCommand.ExecuteAsync(_viewModel.ArtistName);
            await Navigation.PushAsync(new ResultsPage(_viewModel.ArtistData));
        }
    }
}
