using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace xamarin_studies.ViewModels
{
    public class MenuPageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand<string> OnNavigationCommand { get; set; }

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OnNavigationCommand = new DelegateCommand<string>(NavigateAsync);
        }
        async void NavigateAsync(string page)
        {
            await _navigationService.NavigateAsync(new Uri(page, UriKind.Relative));
        }
    }
}
