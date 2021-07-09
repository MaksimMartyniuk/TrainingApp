using DataLayer.BusinessObjects;
using DataLayer.Factories;
using DataLayer.Repositories;
using DataLayer.JSON.Repositories;

namespace DataLayer.JSON.Factories
{
	public class JSONRepositoryAbstractFactory : IRepositoryAbstractFactory<ObjectBase>
	{
		private string rootPath;

		public JSONRepositoryAbstractFactory(string path)
		{
			rootPath = path;
		}

		public IRepository<ObjectBase> CreateOrderRepository()
		{
			return new EntityJSONRepository(rootPath + "\\Orders");
		}

		public IRepository<ObjectBase> CreatePassportRepository()
		{
			return new EntityJSONRepository(rootPath + "\\Passports");
		}

		public IRepository<ObjectBase> CreateUserRepository()
		{
			return new EntityJSONRepository(rootPath + "\\Users");
		}
	}
}
