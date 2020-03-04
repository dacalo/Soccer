using Prism.Navigation;
using Soccer.Common.Helpers;
using Soccer.Common.Models;
using Soccer.Common.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Soccer.Prism.ViewModels
{
    public class TournamentsPageViewModel : ViewModelBase
    {
        private readonly IApiService _apiService;
        private List<TournamentResponse> _tournaments;

        public TournamentsPageViewModel(
            INavigationService navigationService,
            IApiService apiService) : base(navigationService)
        {
            _apiService = apiService;
            Title = "Soccer";
            LoadTournamentsAsync();
        }

        public List<TournamentResponse> Tournaments
        {
            get => _tournaments;
            set => SetProperty(ref _tournaments, value);
        }

        private async void LoadTournamentsAsync()
        {
            //string url = App.Current.Resources["UrlAPI"].ToString();
            string url = Constants.URL_BASE;
            Response response = await _apiService.GetListAsync<TournamentResponse>(
                url,
                Constants.SERVICE_PREFIX,
                "/Tournaments");

            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }

            Tournaments = (List<TournamentResponse>)response.Result;
        }
    }
}
