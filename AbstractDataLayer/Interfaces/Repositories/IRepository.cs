using DataLayer.Interfaces.Entities;
using System;
using System.Collections.Generic;

namespace DataLayer.Interfaces.Repositories
{
	public interface IRepository<IEntity>
	{
		IEnumerable<IEntity> GetObjectList();
		IEntity GetObject(Guid id);
		void Create(IEntity item);
		void Update(IEntity item);
		void Delete(Guid id);
	}
}
