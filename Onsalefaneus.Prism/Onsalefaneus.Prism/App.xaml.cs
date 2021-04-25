using OnSale.Common.Services;
using Onsalefaneus.Prism.ViewModels;
using Onsalefaneus.Prism.Views;
using Prism;
using Prism.Ioc;
using Syncfusion.Licensing;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Onsalefaneus.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            //NDMyMjE2QDMxMzkyZTMxMmUzMFplR0xRVXQzUUZrNGZZOXRrRm1pY0dGeFhoNkx2bzRyeCtYakdxTWVhVU09
            SyncfusionLicenseProvider.RegisterLicense("NDMyMjE2QDMxMzkyZTMxMmUzMFplR0xRVXQzUUZrNGZZOXRrRm1pY0dGeFhoNkx2bzRyeCtYakdxTWVhVU09");
            InitializeComponent();            

            await NavigationService.NavigateAsync($"{nameof(Views.OnSaleMasterDetailPage)}/NavigationPage/{nameof(ProductsPage)}");

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.Register<IApiService, ApiService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductsPage, ProductsPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductDetailPage, ProductDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<Views.OnSaleMasterDetailPage, OnSaleMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ShowCarPage, ShowCarPageViewModel>();
            containerRegistry.RegisterForNavigation<ShowHistoryPage, ShowHistoryPageViewModel>();
            containerRegistry.RegisterForNavigation<ModifyUserPage, ModifyUserPageViewModel>();
            containerRegistry.RegisterForNavigation<QualificationsPage, QualificationsPageViewModel>();
            containerRegistry.RegisterForNavigation<QualificationDetailPage, QualificationDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductTabbedPage, ProductTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<AddQualificationPage, AddQualificationPageViewModel>();
        }
    }
}
