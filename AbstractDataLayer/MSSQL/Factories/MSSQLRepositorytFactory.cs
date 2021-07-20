using DataLayer.Interfaces.Factories;
using DataLayer.Interfaces.Repositories;
using DataLayer.MSSQL.Repositories;

namespace DataLayer.MSSQL.Factories
{
	public class MSSQLRepositorytFactory : IRepositoryFactory
	{
		private string connectionString;

		public MSSQLRepositorytFactory(string conn)
		{
			connectionString = conn;
		}

		public IOrderRepository CreateOrderRepository()
		{
			return new OrderRepository(connectionString);
		}

		public IPassportRepository CreatePassportRepository()
		{
			return new PassportRepository(connectionString);
		}

		public IUserRepository CreateUserRepository()
		{
			return new UserRepository(connectionString);
		}
	}
}
