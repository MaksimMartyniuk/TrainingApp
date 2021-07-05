using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TrainingApp.BusinessObjects;
using TrainingApp.MSSQL;

namespace TrainingApp.Repositories
{
	public class OrderEntityMSSQLRepository : IRepository<Order>
	{
		private string connectionString;

		public OrderEntityMSSQLRepository(string conn)
		{
			connectionString = conn;
		}

		public void Create(Order item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				context.Orders.Add(item);
				context.SaveChanges();
			}
		}
		public Order GetObject(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Orders.Find(id);
			}
		}

		public void Update(Order item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				context.Entry(item).State = EntityState.Modified;
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

		public IEnumerable<Order> GetObjectList()
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Orders;
			}
		}
	}
}
