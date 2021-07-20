using DataLayer.Interfaces.Entities;
using DataLayer.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DataLayer.JSON.Repositories
{
	public class EntityRepository<T> : IRepository<T> where T : class, IEntity
	{
		private string rootPath;

		public EntityRepository(string path)
		{
			rootPath = path;
		}

		public void Create(T item)
		{
			File.WriteAllText(MakePath(rootPath, item.Id.ToString()), GetJSON(item));
		}

		public T GetObject(Guid id)
		{
			return JsonSerializer.Deserialize<T>(File.ReadAllText(MakePath(rootPath, id.ToString()))); ;
		}

		public void Update(T item)
		{
			File.WriteAllText(MakePath(rootPath, item.Id.ToString()), GetJSON(item));
		}

		public void Delete(Guid id)
		{
			File.Delete(MakePath(rootPath, id.ToString()));
		}

		public IEnumerable<T> GetObjectList()
		{
			List<T> result = new List<T>();
			IEnumerable<string> files = Directory.EnumerateFiles(rootPath);
			foreach (string filename in files)
			{
				result.Add(GetObject(Guid.Parse(filename)));
			}
			return result;
		}

		private string GetJSON(T item)
		{
			return JsonSerializer.Serialize(item);
		}

		private string MakePath(string path, string id)
		{
			return string.Format("{0}\\{1}.json", path, id);
		}
	}
}
