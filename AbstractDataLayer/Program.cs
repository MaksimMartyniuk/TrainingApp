using DataLayer.Interfaces.Entities;
using DataLayer.Interfaces.Factories;
using DataLayer.Interfaces.Repositories;
//using DataLayer.JSON.Factories;
//using DataLayer.JSON.Entities;
using DataLayer.MSSQL.Entities;
using DataLayer.MSSQL.Factories;
using System;

namespace DataLayer
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			IRepositoryFactory repFactory =
				//new JSONRepositoryFactory("C:\\Users\\Maksim_Martyniuk\\source\\repos\\TrainingApp");
				new MSSQLRepositorytFactory("Server=(localdb)\\MSSQLLocalDB;Database=TrainingAppDb;");

			User user = new User
			{
				Id = Guid.NewGuid(),
				FirstName = "Name",
			};

			IRepository<IEntity> rep = repFactory.CreateUserRepository() as IRepository<IEntity>;
			rep.Create(user);


			Order order = new Order
			{
				Id = Guid.NewGuid(),
				OrderDate = DateTime.Now,
				OrderNumber = 1,
				OrderStatus = Enums.OrderStatusEnum.Open,
				User = user
			};

			rep = repFactory.CreateOrderRepository() as IRepository<IEntity>;
			rep.Create(order);

			

			
			//IRepository<IEntity> rep = repFactory.CreateUserRepository();

			//rep.Create(user);

			var Passport = new Passport
			{
				Id = Guid.NewGuid(),
				Series = "MC",
				User = user
			};


			rep = repFactory.CreatePassportRepository() as IRepository<IEntity>;

			//Passport user2 = rep.GetObject(Guid.Parse("2b65c698-16f5-46cd-9922-e13dee9ccad5")) as Passport;


			rep.Create(Passport);
		}
	}
}
