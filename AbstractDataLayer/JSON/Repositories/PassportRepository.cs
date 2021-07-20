using DataLayer.Interfaces.Entities;
using DataLayer.Interfaces.Repositories;
using DataLayer.JSON.Entities;
using System;
using System.Collections.Generic;

namespace DataLayer.JSON.Repositories
{
	public class PassportRepository : EntityRepository<Passport>, IPassportRepository 
	{
		public PassportRepository(string conn) : base(conn) { }

		public void Create(IPassport item)
		{
			base.Create((Passport)item);
		}

		public void Update(IPassport item)
		{
			base.Update((Passport)item);
		}

		IPassport IRepository<IPassport>.GetObject(Guid id)
		{
			return base.GetObject(id);
		}

		IEnumerable<IPassport> IRepository<IPassport>.GetObjectList()
		{
			return base.GetObjectList();
		}
	}
}
