using Prism.Unity;
using PrismDeNaviNavi.Views;
using Xamarin.Forms;

namespace PrismDeNaviNavi
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<Page1>();
            Container.RegisterTypeForNavigation<Page2>();
            Container.RegisterTypeForNavigation<SubPage1>();
            Container.RegisterTypeForNavigation<SubPage2>();
        }
    }
}
