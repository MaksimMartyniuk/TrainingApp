using DataLayer.Interfaces.Entities;
using DataLayer.Interfaces.Repositories;
using DataLayer.MSSQL.Entities;
using System;
using System.Collections.Generic;

namespace DataLayer.MSSQL.Repositories
{
	public class OrderRepository : EntityRepository<Order>, IOrderRepository 
	{
		public OrderRepository(string conn) : base(conn) { }

		public void Create(IOrder item)
		{
			base.Create((Order)item);
		}

		public void Update(IOrder item)
		{
			base.Update((Order)item);
		}

		IOrder IRepository<IOrder>.GetObject(Guid id)
		{
			return base.GetObject(id);
		}

		IEnumerable<IOrder> IRepository<IOrder>.GetObjectList()
		{
			return base.GetObjectList();
		}
	}
}
