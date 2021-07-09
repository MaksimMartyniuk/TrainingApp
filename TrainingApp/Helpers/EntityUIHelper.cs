using DataLayer.BusinessObjects;
using ConsoleUILayer.UI;

namespace ConsoleUILayer.Helpers
{
	public class EntityUIHelper
	{
		public IEntityConsoleUI<ObjectBase> SelectUI(string entity)
		{
			switch (entity)
			{
				case "User":
					return new UserConsoleUI();
				case "Order":
					return new OrderConsoleUI();
				case "Passport":
					return new PassportConsoleUI();
				default:
					return null;
			}
		}
	}
}
