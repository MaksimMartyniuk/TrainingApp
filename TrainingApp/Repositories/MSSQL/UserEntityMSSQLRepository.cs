using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TrainingApp.BusinessObjects;
using TrainingApp.Factories;

namespace TrainingApp.Repositories.MSSQL
{
	public class UserEntityMSSQLRepository : IRepository<User>
	{
		private IFactory<MSSQLContext> factory;

		public UserEntityMSSQLRepository(IFactory<MSSQLContext> factory)
		{
			this.factory = factory;
		}

		public void Create(User item)
		{
			using (MSSQLContext context = factory.Create())
			{
				context.Users.Add(item);
				context.SaveChanges();
			}
		}
		public User GetObject(Guid id)
		{
			using (MSSQLContext context = factory.Create())
			{
				return context.Users.Find(id);
			}
		}

		public void Update(User item)
		{
			using (MSSQLContext context = factory.Create())
			{
				context.Entry(item).State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		public void Delete(Guid id)
		{
			using (MSSQLContext context = factory.Create())
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
			using (MSSQLContext context = factory.Create())
			{
				return context.Users;
			}
		}
	}
}
