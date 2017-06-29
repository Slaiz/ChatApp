using Prism.Mvvm;

namespace ChatApp.Model {
	public class ChanelModel:BindableBase {
		private string _userImage;
		private string _userName;
		private string _lastMessege;
		private int _messegeCount;

		public string UserImage {
			get {
				return _userImage;
			}
			set {
				SetProperty( ref _userImage, value );
			}
		}

		public string UserName {
			get {
				return _userName;
			}
			set {
				SetProperty( ref _userName, value );
			}
		}

		public string LastMessege {
			get {
				return _lastMessege;
			}
			set {
				SetProperty( ref _lastMessege, value );
			}
		}

		public int MessegeCount {
			get {
				return _messegeCount;
			}
			set {
				SetProperty( ref _messegeCount, value );
			}
		}
	}
}
