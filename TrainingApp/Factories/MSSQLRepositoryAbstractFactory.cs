using TrainingApp.BusinessObjects;
using TrainingApp.Repositories;

namespace TrainingApp.Factories
{
	//будет абстрактная фабрика
	public class MSSQLRepositoryAbstractFactory : IRepositoryAbstractFactory
	{
		private string connectionString;

		public MSSQLRepositoryAbstractFactory(string conn)
		{
			connectionString = conn;
		}

		public IRepository<Order> CreateOrderRepository()
		{
			return new OrderEntityMSSQLRepository(connectionString);
		}

		public IRepository<Passport> CreatePassportRepository()
		{
			return new PassportEntityMSSQLRepository(connectionString);
		}

		public IRepository<User> CreateUserRepository()
		{
			return new UserEntityMSSQLRepository(connectionString);
		}
	}
}
