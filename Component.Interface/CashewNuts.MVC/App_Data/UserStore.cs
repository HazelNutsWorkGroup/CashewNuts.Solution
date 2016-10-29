using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashewNuts.MVC.Stores
{
	public class UserStore<TUser> : IUserStore<TUser> where TUser : class,IUser
	{
		private Models.ApplicationDbContext applicationDbContext;

		public UserStore(Models.ApplicationDbContext applicationDbContext)
		{
			// TODO: Complete member initialization
			this.applicationDbContext = applicationDbContext;
		}

		public System.Threading.Tasks.Task CreateAsync(TUser user)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task DeleteAsync(TUser user)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<TUser> FindByIdAsync(string userId)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<TUser> FindByNameAsync(string userName)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task UpdateAsync(TUser user)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
		}
	}
}