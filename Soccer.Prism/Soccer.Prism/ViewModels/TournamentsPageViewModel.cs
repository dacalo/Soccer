using Prism.Navigation;
using Soccer.Common.Helpers;
using Soccer.Common.Models;
using Soccer.Common.Services;
using System.Collections.Generic;
using System.Linq;

namespace Soccer.Prism.ViewModels
{
    public class TournamentsPageViewModel : ViewModelBase
    {
        private readonly IApiService _apiService;
        private readonly INavigationService _navigationService;
        private List<TournamentItemViewModel> _tournaments;

        public TournamentsPageViewModel(
            INavigationService navigationService,
            IApiService apiService) : base(navigationService)
        {
            _navigationService = navigationService;
            _apiService = apiService;
            Title = "Soccer";
            LoadTournamentsAsync();
        }

        public List<TournamentItemViewModel> Tournaments
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

            List<TournamentResponse> list = (List<TournamentResponse>)response.Result;
            Tournaments = list.Select(t => new TournamentItemViewModel(_navigationService)
            {
                EndDate = t.EndDate,
                Groups = t.Groups,
                Id = t.Id,
                IsActive = t.IsActive,
                LogoPath = t.LogoPath,
                Name = t.Name,
                StartDate = t.StartDate
            }).ToList();

        }
    }
}
