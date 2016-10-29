using System;

namespace CashewNuts.MVC.Contexts
{
	public class IdentityDbContext<TUser> : IDisposable
	{
		private string p;
		private bool throwIfV1Schema;

		public IdentityDbContext(string nameOrConnectionString, bool throwIfV1Schema)
		{
			// TODO: Complete member initialization
			this.p = nameOrConnectionString;
			this.throwIfV1Schema = throwIfV1Schema;
		}

		public void Dispose()
		{
		}
	}
}