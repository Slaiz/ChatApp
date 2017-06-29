using Prism.Unity;
using ChatApp.Views;
using Xamarin.Forms;

namespace ChatApp {
	public partial class App : PrismApplication {
		public App ( IPlatformInitializer initializer = null ) : base( initializer ) { }

		protected override void OnInitialized () {
			InitializeComponent();

			NavigationService.NavigateAsync( "" );
		}

		protected override void RegisterTypes () {
		}
	}
}
