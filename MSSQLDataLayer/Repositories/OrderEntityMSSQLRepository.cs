using AbstractDataLayer.BusinessObjects;
using AbstractDataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using MSSQLDataLayer.MSSQL;
using System;
using System.Collections.Generic;

namespace MSSQLDataLayer.Repositories
{
	public class OrderEntityMSSQLRepository : IRepository<ObjectBase>
	{
		private Order order;

		private string connectionString;

		public OrderEntityMSSQLRepository(string conn)
		{
			connectionString = conn;
		}

		public void Create(ObjectBase item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				if ((order = ToOrder(item)) == null)
					return;

				context.Orders.Add(order);
				context.SaveChanges();
			}
		}
		public ObjectBase GetObject(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Orders.Find(id);
			}
		}

		public void Update(ObjectBase item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				if ((order = ToOrder(item)) == null)
					return;

				context.Entry(order).State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		public void Delete(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				Order order = context.Orders.Find(id);
				if (order != null)
				{
					context.Orders.Remove(order);
					context.SaveChanges();
				}
			}
		}

		public IEnumerable<ObjectBase> GetObjectList()
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Orders;
			}
		}

		private Order ToOrder(ObjectBase item)
		{
			Order order = item as Order;
			if (order == null)
			{
				Console.WriteLine("Order item is not valid");
				return null;
			}
			else
			{
				return order;
			}
		}
	}
}
