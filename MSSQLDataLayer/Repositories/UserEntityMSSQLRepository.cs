using AbstractDataLayer.BusinessObjects;
using AbstractDataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using MSSQLDataLayer.MSSQL;
using System;
using System.Collections.Generic;

namespace MSSQLDataLayer.Repositories
{
	public class UserEntityMSSQLRepository : IRepository<ObjectBase>
	{
		private User user;

		private string connectionString;

		public UserEntityMSSQLRepository(string conn)
		{
			connectionString = conn;
		}

		public void Create(ObjectBase item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				if ((user = ToUser(item)) == null)
					return;

				context.Users.Add(user);
				context.SaveChanges();
			}
		}
		public ObjectBase GetObject(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Users.Find(id);
			}
		}

		public void Update(ObjectBase item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				if ((user = ToUser(item)) == null)
					return;

				context.Entry(item).State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		public void Delete(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				User user = context.Users.Find(id);
				if (user != null)
				{
					context.Users.Remove(user);
					context.SaveChanges();
				}
			}
		}

		public IEnumerable<ObjectBase> GetObjectList()
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Users;
			}
		}

		private User ToUser(ObjectBase item)
		{
			User user = item as User;
			if (user == null)
			{
				Console.WriteLine("User item is not valid");
				return null;
			}
			else
			{
				return user;
			}
		}
	}
}
