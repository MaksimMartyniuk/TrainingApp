using AbstractDataLayer.BusinessObjects;
using AbstractDataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using MSSQLDataLayer.MSSQL;
using System;
using System.Collections.Generic;

namespace MSSQLDataLayer.Repositories
{
	public class PassportEntityMSSQLRepository : IRepository<ObjectBase>
	{
		private Passport passport;

		private string connectionString;

		public PassportEntityMSSQLRepository(string conn)
		{
			connectionString = conn;
		}

		public void Create(ObjectBase item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				if ((passport = ToPassport(item)) == null)
					return;

				context.Passports.Add(passport);
				context.SaveChanges();
			}
		}
		public ObjectBase GetObject(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Passports.Find(id);
			}
		}

		public void Update(ObjectBase item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				if ((passport = ToPassport(item)) == null)
					return;

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

		public IEnumerable<ObjectBase> GetObjectList()
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Passports;
			}
		}

		private Passport ToPassport(ObjectBase item)
		{
			Passport passport = item as Passport;
			if (passport == null)
			{
				Console.WriteLine("Passport item is not valid");
				return null;
			}
			else
			{
				return passport;
			}
		}
	}
}
