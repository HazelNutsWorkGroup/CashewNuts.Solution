using Microsoft.AspNet.Identity;

namespace CashewNuts.MVC.Models
{
	public class IdentityUser : IUser, IUser<string>
	{
		private string userId;
		private string userName;

		public IdentityUser()
		{
			this.userId = "";
			this.userName = "";
		}

		public IdentityUser(string userName)
		{
			this.userId = "";
			this.userName = userName;
		}

		public string Id
		{
			get { return userId; }
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set
			{
				userName = value;
			}
		}
	}
}