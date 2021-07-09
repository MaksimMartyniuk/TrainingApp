using DataLayer.BusinessObjects;
using DataLayer.Factories;
using DataLayer.Repositories;

namespace ConsoleUILayer.Helpers
{
	public class RepositoryHelper
	{
		public IRepository<ObjectBase> GetRepository(IRepositoryAbstractFactory<ObjectBase> factory, string type)
		{
			switch (type)
			{
				case "User":
					return factory.CreateUserRepository();
				case "Order":
					return factory.CreateOrderRepository();
				case "Passport":
					return factory.CreatePassportRepository();
				default:
					return null;
			}
		}
	}
}
