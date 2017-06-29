using Prism.Unity;
using ChatApp.Views;
using Xamarin.Forms;

namespace ChatApp {
	public partial class App : PrismApplication {
		public App ( IPlatformInitializer initializer = null ) : base( initializer ) { }

		protected override void OnInitialized () {
			InitializeComponent();

			MainPage = new ContentPage();
			NavigationService.NavigateAsync( "MainNavigationPage/LoginPage" );
		}

		protected override void RegisterTypes () {
			Container.RegisterTypeForNavigation<MainNavigationPage>();
			Container.RegisterTypeForNavigation<LoginPage>();
			Container.RegisterTypeForNavigation<ViewChanelPage>();
		}
	}
}
