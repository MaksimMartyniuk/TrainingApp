using DataLayer.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.MSSQL.Entities
{
	[Table("User")]
	public class User : IUser
	{
		public Guid Id { get; set; }

		public string FirstName { get; set; }

		public string MindleName { get; set; }

		public string LastName { get; set; }

		public int Age { get; set; }

		public Passport Passport { get; set; }

		[NotMapped]
		IPassport IUser.Passport
		{
			set { Passport = value as Passport; }
			get { return Passport; }
		}

		public List<Order> Orders = new List<Order>();

		[NotMapped]
		IEnumerable<IOrder> IUser.Orders
		{
			set { Orders = value as List<Order>; }
			get { return Orders; }
		}
	}
}