using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.BusinessObjects;
using TrainingApp.Repositories;

namespace TrainingApp.Factories
{
	public class JSONRepositoryAbstractFactory : IRepositoryAbstractFactory
	{
		public IRepository<Order> CreateOrderRepository()
		{
			throw new NotImplementedException();
		}

		public IRepository<Passport> CreatePassportRepository()
		{
			throw new NotImplementedException();
		}

		public IRepository<User> CreateUserRepository()
		{
			throw new NotImplementedException();
		}
	}
}
