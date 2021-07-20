using System.Collections.Generic;

namespace DataLayer.Interfaces.Entities
{
	public interface IUser : IEntity
	{
		public string FirstName { get; set; }

		public string MindleName { get; set; }

		public string LastName { get; set; }

		public int Age { get; set; }

		public IPassport Passport { get; set; }

		public IEnumerable<IOrder> Orders { get; set; }

	}
}