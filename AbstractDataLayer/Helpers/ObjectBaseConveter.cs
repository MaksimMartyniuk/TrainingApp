
using DataLayer.BusinessObjects;

namespace DataLayer.Helpers
{
	public static class ObjectBaseConveter
	{
		public static User ToUser(ObjectBase item)
		{
			User user = item as User;
			if (user == null)
			{
				return null;
			}
			else
			{
				return user;
			}
		}

		public static Passport ToPassport(ObjectBase item)
		{
			Passport passport = item as Passport;
			if (passport == null)
			{
				return null;
			}
			else
			{
				return passport;
			}
		}

		public static Order ToOrder(ObjectBase item)
		{
			Order order = item as Order;
			if (order == null)
			{
				return null;
			}
			else
			{
				return order;
			}
		}
	}
}
