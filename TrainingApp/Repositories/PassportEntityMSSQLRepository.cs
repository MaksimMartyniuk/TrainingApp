using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TrainingApp.BusinessObjects;
using TrainingApp.MSSQL;

namespace TrainingApp.Repositories
{
	public class PassportEntityMSSQLRepository : IRepository<Passport>
	{
		private string connectionString;

		public PassportEntityMSSQLRepository(string conn)
		{
			connectionString = conn;
		}

		public void Create(Passport item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				context.Passports.Add(item);
				context.SaveChanges();
			}
		}
		public Passport GetObject(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Passports.Find(id);
			}
		}

		public void Update(Passport item)
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
				Passport passport = context.Passports.Find(id);
				if (passport != null)
				{
					context.Passports.Remove(passport);
					context.SaveChanges();
				}
			}
		}

		public IEnumerable<Passport> GetObjectList()
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Passports;
			}
		}
	}
}
