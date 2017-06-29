using ChatApp.Views;
using Prism.Unity;

namespace ChatApp {
	public partial class App : PrismApplication {
		public App ( IPlatformInitializer initializer = null ) : base( initializer ) { }

		protected override void OnInitialized () {
			InitializeComponent();

			NavigationService.NavigateAsync( "MainNavigationPage/LoginPage", animated:false );
		}

		protected override void RegisterTypes () {
			Container.RegisterTypeForNavigation<MainNavigationPage>();
			Container.RegisterTypeForNavigation<LoginPage>();
			Container.RegisterTypeForNavigation<ChanelsListPage>();
		}
	}
}
