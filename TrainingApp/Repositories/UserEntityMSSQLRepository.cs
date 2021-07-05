using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TrainingApp.BusinessObjects;
using TrainingApp.MSSQL;

namespace TrainingApp.Repositories
{
	public class UserEntityMSSQLRepository : IRepository<User>
	{
		private string connectionString;

		public UserEntityMSSQLRepository(string conn)
		{
			connectionString = conn;
		}

		public void Create(User item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				context.Users.Add(item);
				context.SaveChanges();
			}
		}
		public User GetObject(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Users.Find(id);
			}
		}

		public void Update(User item)
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
				User user = context.Users.Find(id);
				if (user != null)
				{
					context.Users.Remove(user);
					context.SaveChanges();
				}
			}
		}

		public IEnumerable<User> GetObjectList()
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Users;
			}
		}
	}
}
