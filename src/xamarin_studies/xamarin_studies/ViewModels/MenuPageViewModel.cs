using System;
using Prism.Commands;
using Prism.Navigation;

namespace xamarin_studies.ViewModels
{
    public class MenuPageViewModel : BaseViewModel
    {
        public DelegateCommand<string> OnNavigationCommand { get; set; }

        public MenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            OnNavigationCommand = new DelegateCommand<string>(NavigateAsync);
        }

        private async void NavigateAsync(string page)
        {
            await NavigationService.NavigateAsync(new Uri(page, UriKind.Relative));
        }
    }
}
