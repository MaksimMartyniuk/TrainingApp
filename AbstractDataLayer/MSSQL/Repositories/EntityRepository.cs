using DataLayer.Interfaces.Entities;
using DataLayer.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataLayer.MSSQL.Repositories
{
	public class EntityRepository<T> : IRepository<T> where T : class, IEntity
	{
		private string connectionString;

		public EntityRepository(string conn)
		{
			connectionString = conn;
		}

		public void Create(T item)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				context.Set<T>().Add(item);
				context.SaveChanges();
			}
		}
		public T GetObject(Guid id)
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Set<T>().Find(id);
			}
		}

		public void Update(T item)
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
				var entity = context.Set<T>().Find(id);
				if (entity != null)
				{
					context.Set<T>().Remove(entity);
					context.SaveChanges();
				}
			}
		}

		public IEnumerable<T> GetObjectList()
		{
			using (MSSQLContext context = new MSSQLContext(connectionString))
			{
				return context.Set<T>();
			}
		}


	}
}
