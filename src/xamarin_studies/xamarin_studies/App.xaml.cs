using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_studies.Views;
using xamarin_studies.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace xamarin_studies
{
    public partial class App : PrismApplication
    {
        public App() : this(null)
        {

        }
        public App(IPlatformInitializer initializer) : this(initializer, true)
        {

        }
        public App(IPlatformInitializer initializer, bool setFormsDependencyResolver) : base(initializer, setFormsDependencyResolver)
        {

        }
        protected override async void OnInitialized()
        {
            InitializeComponent();
#if DEBUG
            HotReloader.Current.Start(this);
#endif
            await NavigationService.NavigateAsync(new System.Uri("/MenuPage/NavigationPage/", System.UriKind.Absolute));

        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<BeerAvailabilityMenuPage,BeerAvailabilityMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<CategoriesMenuPage,CategoriesMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<CountriesMenuPage,CountriesMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<EventTypesMenuPage,EventTypesMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<FluidSizeMenuPage,FluidSizeMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<FluidsizeVolumeMenuPage,FluidsizeVolumeMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<GlasswareMenuPage,GlasswareMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage,HomePageViewModel>();
            containerRegistry.RegisterForNavigation<IngredientsMenuPage,IngredientsMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<MainPage,MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage,MenuPageViewModel>();
            containerRegistry.RegisterForNavigation<LocationTypesMenuPage,LocationTypesMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<SrmMenuPage,SrmMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<StylesMenuPage,StylesMenuPageViewModel>();
        }
    }
}
