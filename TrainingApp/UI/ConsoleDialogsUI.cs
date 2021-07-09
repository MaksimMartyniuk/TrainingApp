using DataLayer.BusinessObjects;
using DataLayer.Factories;
using DataLayer.Repositories;
using ConsoleUILayer.Helpers;
using Microsoft.Extensions.Configuration;
using System;

namespace ConsoleUILayer.UI
{
	public class ConsoleDialogsUI
	{
		public static void StartDialog(IConfiguration configuration)
		{
			while (true)
			{
				string connectionString = null;

				Console.WriteLine("Choose data store type:\n" +
					"1 MSSQL\n" +
					"2 JSON\n" +
					"0 Exit");

				var dataType = Console.ReadLine();

				switch (dataType)
				{
					case "1":
						connectionString = configuration.GetConnectionString("DefaultSQLConnection");
						dataType = "MSSQL";
						break;
					case "2":
						connectionString = configuration.GetConnectionString("DefaultJSONFolderPath");
						dataType = "JSON";
						break;
					case "0":
						return;
					default:
						Console.WriteLine("Wrong data storage type");
						continue;
				}

				if(connectionString == null)
				{
					Console.WriteLine("Connection string not managed");
					continue;
				}

				FactoryHelper factoryHelper = new FactoryHelper();

				if (!RepositoryInitializeDialog(factoryHelper.
					GetRepositoryAbstractFactory(dataType, connectionString)))
					return;
			}
		}

		public static bool RepositoryInitializeDialog
			(IRepositoryAbstractFactory<ObjectBase> factory)
		{
			RepositoryHelper repositoryHelper = new RepositoryHelper();

			if (factory == null)
			{
				Console.WriteLine("Rep factory not initialized");
				return true;
			}

			while(true)
			{
				bool continueWorking = true;

				Console.WriteLine("Choose entity:\n" +
					"1 User\n" +
					"2 Passport\n" +
					"3 Order\n" +
					"< Back to storage type\n" +
					"0 Exit");

				string entity = Console.ReadLine();

				switch (entity)
				{
					case "1":
						entity = "User";
						break;
					case "2":
						entity = "Passport";
						break;
					case "3":
						entity = "Order";
						break;
					case "<":
						return true;
					case "0":
						return false;
					default:
						Console.WriteLine("Wrong entity type");
						continue;
				}

				continueWorking = CommandDialoge(repositoryHelper.GetRepository(factory, entity), entity);

				if (!continueWorking)
					return false;
			}
		}

		public static bool CommandDialoge(IRepository<ObjectBase> repository, string entity)
		{
			FactoryHelper factoryHelper = new FactoryHelper();

			EntityUIHelper entityUIHelper = new EntityUIHelper();

			IBusinessObjectFactory<ObjectBase> factory = factoryHelper.GetEntityFactory(entity);

			if(factory == null || repository == null)
			{
				return true;
			}

			var ui = entityUIHelper.SelectUI(entity);
			if (ui == null)
			{
				Console.WriteLine("Wrong UI");
				return true;
			}

			while (true)
			{
				Console.WriteLine("Choose command:\n" +
					"1 Create\n" +
					"2 Get\n" +
					"3 Update\n" +
					"4 Delete\n" +
					"5 GetAll\n" +
					"< Back to storage entity type\n" +
					"0 Exite");

				string option = Console.ReadLine();

				switch (option)
				{
					case "1":
						var item = factory.Create();
						if (item == null)
						{
							Console.WriteLine("Item is null");
							break;
						}

						ui.EntityInitialize(item);

						repository.Create(item);

						break;
					case "2":
						ui.ShowEntity(repository.GetObject(Guid.Parse(Console.ReadLine())));

						break;
					case "3":
						break;
					case "4":
						break;
					case "5":
						break;
					case "<":
						return true;
					case "0":
						return false;
					default:
						Console.WriteLine("Wrong command");
						break;
				}
			}
		}

	}
}
