using DataLayer.BusinessObjects;
using DataLayer.Factories;
using DataLayer.JSON.Factories;
using DataLayer.MSSQL.Factories;

namespace ConsoleUILayer.Helpers
{
	public class FactoryHelper
	{
		public IRepositoryAbstractFactory<ObjectBase> GetRepositoryAbstractFactory(string type, string connectionString)
		{
			switch (type)
			{
				case "MSSQL":
					return new MSSQLRepositoryAbstractFactory
						(connectionString);
				case "JSON":
					return new JSONRepositoryAbstractFactory
						(connectionString);
				default:
					return null;
			}
		}

		public IBusinessObjectFactory<ObjectBase> GetEntityFactory(string entity)
		{
			switch (entity)
			{
				case "User":
					return new UserFactory();
				case "Order":
					return new OrderFactory();
				case "Passport":
					return new PassportFactory();
				default:
					return null;
			}
		}
	}
}
