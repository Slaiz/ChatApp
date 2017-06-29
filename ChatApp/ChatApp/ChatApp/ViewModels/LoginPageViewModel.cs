using System.Windows.Input;
using Prism.Mvvm;
using ChatApp.Model;
using ChatApp.Views;
using Prism.Commands;
using Prism.Navigation;

namespace ChatApp.ViewModels {
	public class LoginPageViewModel : BindableBase {
		private readonly INavigationService _navigationService;
		private UserModel _user;

		public LoginPageViewModel(
			INavigationService navigationService) {
			_navigationService = navigationService;
		}

		public UserModel User {
			get {
				return _user;
			}
			set {
				SetProperty( ref _user, value );
			}
		}

		public ICommand LogInCommand {
			get {
				return new DelegateCommand( async () => {
					await _navigationService.NavigateAsync( nameof( ChanelsListPage ) );
				} );
			}
		}
	}
}
