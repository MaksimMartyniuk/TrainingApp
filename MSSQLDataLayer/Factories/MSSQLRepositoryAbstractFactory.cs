using AbstractDataLayer.BusinessObjects;
using AbstractDataLayer.Factories;
using AbstractDataLayer.Repositories;
using MSSQLDataLayer.Repositories;

namespace MSSQLDataLayer.Factories
{
	//будет абстрактная фабрика
	public class MSSQLRepositoryAbstractFactory : IRepositoryAbstractFactory<ObjectBase>
	{
		private string connectionString;

		public MSSQLRepositoryAbstractFactory(string conn)
		{
			connectionString = conn;
		}

		public IRepository<ObjectBase> CreateOrderRepository()
		{
			return new OrderEntityMSSQLRepository(connectionString);
		}

		public IRepository<ObjectBase> CreatePassportRepository()
		{
			return new PassportEntityMSSQLRepository(connectionString);
		}

		public IRepository<ObjectBase> CreateUserRepository()
		{
			return new UserEntityMSSQLRepository(connectionString);
		}
	}
}
