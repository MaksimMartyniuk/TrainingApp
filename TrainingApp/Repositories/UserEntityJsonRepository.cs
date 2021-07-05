using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TrainingApp.BusinessObjects;

namespace TrainingApp.Repositories
{
	public class UserEntityJsonRepository : IRepository<User>
	{
		public void Create(User item)
		{
			List<User> users = new List<User>();
			users.Add(item);
		}

		public void Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public User GetObject(Guid id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetObjectList()
		{
			throw new NotImplementedException();
		}

		public void Update(User item)
		{
			throw new NotImplementedException();
		}
	}
}
