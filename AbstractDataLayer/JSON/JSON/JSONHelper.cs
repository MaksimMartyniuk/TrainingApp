using DataLayer.BusinessObjects;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DataLayer.JSON.JSON
{
	// избавиться
	public static class JSONHelper
	{
		public static string MakePath(string path, string id)
		{
			return string.Format("{0}\\{1}.json", path, id);
		}

		public static void Serialize<T>(string path, string id, T item) where T : ObjectBase
		{
			item.GetType();
			//проверить сериализацию сразу в поток
			File.WriteAllText(MakePath(path, id.ToString()), JsonSerializer.Serialize(item));
		}

		public static T Deserialize<T>(string path, string id)
		{
			return JsonSerializer.Deserialize<T>(File.ReadAllText(MakePath(path, id.ToString())));
		}

		public static void Delete(string root, string id)
		{
			File.Delete(MakePath(root, id.ToString()));
		}

		public static IEnumerable<T> GetObjectList<T>(string path)
		{
			List<T> result = new List<T>();
			IEnumerable<string> files = Directory.EnumerateFiles(path);
			foreach(string filename in files)
			{
				result.Add(Deserialize<T>(path, filename));
			}
			return result;
		}
	}
}
