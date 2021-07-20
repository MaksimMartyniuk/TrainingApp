using DataLayer.Interfaces.Entities;
using DataLayer.Interfaces.Repositories;
using DataLayer.MSSQL.Entities;
using System;
using System.Collections.Generic;

namespace DataLayer.MSSQL.Repositories
{
	public class UserRepository : EntityRepository<User>, IUserRepository 
	{
		public UserRepository(string conn) : base(conn) { }

		public void Create(IUser item)
		{
			base.Create((User)item);
		}

		public void Update(IUser item)
		{
			base.Update((User)item);
		}

		IUser IRepository<IUser>.GetObject(Guid id)
		{
			return base.GetObject(id);
		}

		IEnumerable<IUser> IRepository<IUser>.GetObjectList()
		{
			return base.GetObjectList();
		}
	}
}
