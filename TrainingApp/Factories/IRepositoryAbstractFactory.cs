using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.BusinessObjects;
using TrainingApp.Repositories;

namespace TrainingApp.Factories
{
	public interface IRepositoryAbstractFactory
	{
		IRepository<User> CreateUserRepository();
		IRepository<Order> CreateOrderRepository();
		IRepository<Passport> CreatePassportRepository();
	}
}
