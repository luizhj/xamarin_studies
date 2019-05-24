using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace xamarin_studies.ViewModels
{
    public abstract class BaseViewModel : BindableBase, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; }

        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value, () => RaisePropertyChanged(nameof(IsNotBusy)));
        }

        private bool _listRefreshing;

        public bool ListRefreshing
        {
            get =>_listRefreshing;
            set => SetProperty(ref _listRefreshing, value, () => RaisePropertyChanged(nameof(ListRefreshing)));
        }

        public bool IsNotBusy => !IsBusy;

        protected async Task ExecuteBusyAction(Func<Task> theBusyAction)
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;
                await theBusyAction();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        protected async Task ExecuteListRefreshAction(Func<Task> theBusyAction)
        {
            try
            {
                ListRefreshing = true;
                await theBusyAction();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                ListRefreshing = false;
            }
        }
        public void Destroy()
        {
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
        }
    }
}
