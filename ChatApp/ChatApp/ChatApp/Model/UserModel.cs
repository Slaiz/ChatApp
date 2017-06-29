using Prism.Mvvm;

namespace ChatApp.Model {
	public class UserModel:BindableBase {
		private string _userImage;
		private string _id;
		private string _name;

		public string UserImage {
			get {
				return _userImage;
			}
			set {
				SetProperty( ref _userImage, value );
			}
		}

		public string Id {
			get {
				return _id;
			}
			set {
				SetProperty( ref _id, value );
			}
		}

		public string name {
			get {
				return _name;
			}
			set {
				SetProperty( ref _name, value );
			}
		}
	}
}
