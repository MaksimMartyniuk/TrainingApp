using DataLayer.Interfaces.Repositories;

namespace DataLayer.Interfaces.Factories
{
	public interface IRepositoryFactory
	{
		IUserRepository CreateUserRepository();

		IOrderRepository CreateOrderRepository();

		IPassportRepository CreatePassportRepository();
	}
}
