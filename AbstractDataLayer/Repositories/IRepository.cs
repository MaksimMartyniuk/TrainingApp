using System;
using System.Collections.Generic;

namespace AbstractDataLayer.Repositories
{
	public interface IRepository<T>
		where T : class
	{
		IEnumerable<T> GetObjectList();
		T GetObject(Guid id);
		void Create(T item);
		void Update(T item);
		void Delete(Guid id);
	}
}
