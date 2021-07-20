using System;
using System.ComponentModel.DataAnnotations.Schema;
using DataLayer.Enums;
using DataLayer.Interfaces.Entities;

namespace DataLayer.MSSQL.Entities
{
	public class Order : IOrder
	{
		public Guid Id { get; set; }

		public DateTime OrderDate { get; set; }

		public int OrderNumber { get; set; }

		public OrderStatusEnum OrderStatus { get; set; }

		public User User { get; set; }

		[NotMapped]
		IUser IOrder.User
		{
			set { User = value as User; }
			get { return User; }
		}
	}
}