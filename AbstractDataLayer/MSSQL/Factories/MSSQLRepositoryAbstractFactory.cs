using DataLayer.BusinessObjects;
using DataLayer.Factories;
using DataLayer.MSSQL.Repositories;
using DataLayer.Repositories;

namespace DataLayer.MSSQL.Factories
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
		{//наделать IOrderEntityMSSQLRepository от IRepository<ObjectBase>
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
