using AbstractDataLayer.BusinessObjects;
using AbstractDataLayer.Factories;
using AbstractDataLayer.Repositories;
using JSONDataLayer.Repositories;

namespace JSONDataLayer.Factories
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
			return new EntityJSONRepository(rootPath + "\\Order");
		}

		public IRepository<ObjectBase> CreatePassportRepository()
		{
			return new EntityJSONRepository(rootPath + "\\Passport");
		}

		public IRepository<ObjectBase> CreateUserRepository()
		{
			return new EntityJSONRepository(rootPath + "\\User");
		}
	}
}
