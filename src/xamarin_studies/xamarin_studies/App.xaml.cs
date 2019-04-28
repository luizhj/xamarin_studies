using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_studies.Views;

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

            containerRegistry.RegisterForNavigation<BeerAvailabilityMenuPage>();
            containerRegistry.RegisterForNavigation<CategoriesMenuPage>();
            containerRegistry.RegisterForNavigation<CountriesMenuPage>();
            containerRegistry.RegisterForNavigation<EventTypesMenuPage>();
            containerRegistry.RegisterForNavigation<FluidSizeMenuPage>();
            containerRegistry.RegisterForNavigation<FluidsizeVolumeMenuPage>();
            containerRegistry.RegisterForNavigation<GlasswareMenuPage>();
            containerRegistry.RegisterForNavigation<HomePage>();
            containerRegistry.RegisterForNavigation<IngredientsMenuPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MenuPage>();
            containerRegistry.RegisterForNavigation<LocationTypesMenuPage>();
            containerRegistry.RegisterForNavigation<SrmMenuPage>();
            containerRegistry.RegisterForNavigation<StylesMenuPage>();
        }
    }
}
