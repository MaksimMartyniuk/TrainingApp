using DataLayer.JSON.Repositories;
using DataLayer.JSON.Entities;
using DataLayer.Interfaces.Factories;
using DataLayer.Interfaces.Repositories;

namespace DataLayer.JSON.Factories
{
	public class JSONRepositoryFactory : IRepositoryFactory
	{
		private string rootPath;

		public JSONRepositoryFactory(string path)
		{
			rootPath = path;
		}

		public IOrderRepository CreateOrderRepository()
		{
			return new OrderRepository(rootPath + "\\Orders");
		}

		public IPassportRepository CreatePassportRepository()
		{
			return new PassportRepository(rootPath + "\\Passports");
		}

		public IUserRepository CreateUserRepository()
		{
			return new UserRepository(rootPath + "\\Users");
		}
	}
}
