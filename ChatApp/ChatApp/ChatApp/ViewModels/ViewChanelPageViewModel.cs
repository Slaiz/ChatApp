using ChatApp.Helpers;
using Prism.Mvvm;
using SendBird;

namespace ChatApp.ViewModels {
	public class ViewChanelPageViewModel : BindableBase {


		public ViewChanelPageViewModel () {
			SendBirdClient.Init( ConstantsHelper.APP_ID );
		}


	}
}
