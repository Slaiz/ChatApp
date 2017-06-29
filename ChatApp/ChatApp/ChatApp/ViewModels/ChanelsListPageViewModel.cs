using System.Collections.ObjectModel;
using System.Windows.Input;
using ChatApp.Helpers;
using ChatApp.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SendBird;

namespace ChatApp.ViewModels {
	public class ChanelsListPageViewModel : BindableBase {
		private readonly INavigationService _navigationService;
		private ObservableCollection<ChanelModel> _chanelsList; 

		public ChanelsListPageViewModel (
			INavigationService navigationService ) {
			_navigationService = navigationService;

			SendBirdClient.Init( ConstantsHelper.APP_ID );

			ChanelsList = new ObservableCollection<ChanelModel>( new[ ] {
				new ChanelModel() {
					UserImage = "Add",
					UserName = "Michael Rosa",
					LastMessege = "asfewegwe",
					MessegeCount = 1
				},
				new ChanelModel() {
					UserImage = "Add",
					UserName = "Joy Pank",
					LastMessege = "Hello ",
					MessegeCount = 1
				},
				new ChanelModel() {
					UserImage = "Add",
					UserName = "Klar Kent",
					LastMessege = "",
					MessegeCount = 0
				},
				new ChanelModel() {
					UserImage = "Add",
					UserName = "Olaf kulo",
					LastMessege = "Hello dude",
					MessegeCount = 1
				},
				new ChanelModel() {
					UserImage = "Add",
					UserName = "Michael Rosa",
					LastMessege = "",
					MessegeCount = 0
				},
			} );

		}

		public ObservableCollection<ChanelModel> ChanelsList {
			get {
				return _chanelsList;
			}
			set {
				SetProperty( ref _chanelsList, value );
			}
		}

		public ICommand NavigateToChatPageCommand {
			get {
				return new DelegateCommand( async () => {
					await _navigationService.NavigateAsync( nameof( ChanelsListPageViewModel ) );
				} );
			}
		}
	}
}
