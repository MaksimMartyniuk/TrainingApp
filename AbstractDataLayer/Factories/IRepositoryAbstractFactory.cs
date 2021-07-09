using DataLayer.Repositories;

namespace DataLayer.Factories
{
	public interface IRepositoryAbstractFactory<T>
		where T : class
	{
		IRepository<T> CreateUserRepository();
		IRepository<T> CreateOrderRepository();
		IRepository<T> CreatePassportRepository();
	}
}
