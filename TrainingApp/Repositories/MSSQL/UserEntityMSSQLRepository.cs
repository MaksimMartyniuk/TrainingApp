using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TrainingApp.BusinessObjects;

namespace TrainingApp.Repositories.MSSQL
{
	public class UserEntityMSSQLRepository : IRepository<User>
	{
		public void Create(User item)
		{
			using (MSSQLContext context = new MSSQLContext())
			{
				context.Users.Add(item);
				context.SaveChanges();
			}
		}
		public User GetObject(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext())
			{
				return context.Users.Find(id);
			}
		}

		public void Update(User item)
		{
			using (MSSQLContext context = new MSSQLContext())
			{
				context.Entry(item).State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		public void Delete(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext())
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
			using (MSSQLContext context = new MSSQLContext())
			{
				return context.Users;
			}
		}
	}
}
