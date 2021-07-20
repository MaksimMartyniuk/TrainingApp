using System;
using DataLayer.Enums;

namespace DataLayer.Interfaces.Entities
{//посмотреть мапинг
	public interface IOrder : IEntity
	{
		public DateTime OrderDate { get; set; }

		public int OrderNumber { get; set; }

		public OrderStatusEnum OrderStatus { get; set; }

		public IUser User { get; set; }

	}
}