using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using Refit;
using xamarin_studies.Services;
using xamarin_studies.Models;

namespace xamarin_studies.ViewModels
{
    public class CountriesMenuPageViewModel : BaseViewModel, INavigationAware
    {
        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            CallApi();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }
        async void CallApi()
        {
            await CallApiAsync();
        }
        async Task CallApiAsync()
        {
            var nsApi = RestService.For<IBreweryDBApi>(Constants.ApiBaseUrl);
            var countryMessage = await nsApi.GetCountriesMenu(Constants.ApiKey);
            var countries = countryMessage.Data;
        }
    }
}
