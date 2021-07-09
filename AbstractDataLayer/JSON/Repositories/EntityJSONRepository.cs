using DataLayer.BusinessObjects;
using DataLayer.Repositories;
using DataLayer.JSON.JSON;
using System;
using System.Collections.Generic;

namespace DataLayer.JSON.Repositories
{
	public class EntityJSONRepository : IRepository<ObjectBase>
	{ 
		private string rootPath;

		public EntityJSONRepository(string path)
		{
			rootPath = path;
		}

		public void Create(ObjectBase item)
		{
			JSONHelper.Serialize(rootPath, item.Id.ToString(), item);
		}

		public ObjectBase GetObject(Guid id)
		{
			return JSONHelper.Deserialize<ObjectBase>(rootPath, id.ToString());
		}

		public void Update(ObjectBase item)
		{
			JSONHelper.Serialize(rootPath, item.Id.ToString(), item);
		}

		public void Delete(Guid id)
		{
			JSONHelper.Delete(rootPath, id.ToString());
		}

		public IEnumerable<ObjectBase> GetObjectList()
		{
			return JSONHelper.GetObjectList<ObjectBase>(rootPath);
		}
	}
}
