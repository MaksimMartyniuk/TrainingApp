using DataLayer.BusinessObjects;
using DataLayer.Helpers;
using System;

namespace ConsoleUILayer.UI
{
	public class UserConsoleUI : IEntityConsoleUI<ObjectBase>
	{
		private User user;

		public void EntityInitialize(ObjectBase entity)
		{
			if ((user = ObjectBaseConveter.ToUser(entity)) == null)
				return;

			Console.WriteLine("Enter First Name");
			user.FirstName = Console.ReadLine();

			Console.WriteLine("Enter Midle Name");
			user.MindleName = Console.ReadLine();

			Console.WriteLine("Enter Last Name");
			user.LastName = Console.ReadLine();

			Console.WriteLine("Enter Age");
			user.Age = Int32.Parse(Console.ReadLine());
		}

		public void ShowEntity(ObjectBase entity)
		{
			if ((user = ObjectBaseConveter.ToUser(entity)) == null)
				return;

			Console.WriteLine("First Name" + user.FirstName);

			Console.WriteLine("Midle Name" + user.MindleName);

			Console.WriteLine("Last Name" + user.LastName);

			Console.WriteLine("Age" + user.Age);
		}
	}
}
