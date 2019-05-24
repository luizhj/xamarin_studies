using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Navigation;
using Prism.Commands;
using Refit;
using xamarin_studies.Models;
using xamarin_studies.Services;

namespace xamarin_studies.ViewModels
{
    public class CountriesMenuPageViewModel : BaseViewModel
    {
        public DelegateCommand RefreshListCommand { get; set; }

        private ObservableCollection<Country> _countries;
        public ObservableCollection<Country> CountriesList
        {
            get { return _countries; }
            set { SetProperty(ref _countries, value, () => RaisePropertyChanged(nameof(CountriesList))); }
        }
        public CountriesMenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            RefreshListCommand = new DelegateCommand(async () => await ExecuteListRefreshAction(() => CallApiAsync()));
        }
        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            await ExecuteListRefreshAction(() => CallApiAsync());
        }
        private async Task CallApiAsync()
        {
            var nsApi = RestService.For<IBreweryDBApi>(Constants.ApiBaseUrl);
            var countryMessage = await nsApi.GetCountriesMenu(Constants.ApiKey);
            var countries = countryMessage.Data;
            CountriesList = new ObservableCollection<Country>(countries);
        }
    }
}
