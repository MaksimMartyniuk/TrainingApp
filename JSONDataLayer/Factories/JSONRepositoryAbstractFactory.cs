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
