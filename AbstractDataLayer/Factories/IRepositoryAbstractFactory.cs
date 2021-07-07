using AbstractDataLayer.Repositories;

namespace AbstractDataLayer.Factories
{
	public interface IRepositoryAbstractFactory<T>
		where T : class
	{
		IRepository<T> CreateUserRepository();
		IRepository<T> CreateOrderRepository();
		IRepository<T> CreatePassportRepository();
	}
}
