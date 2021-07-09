using System;
using DataLayer.Enums;

namespace DataLayer.BusinessObjects
{//посмотреть мапинг
	public class Order : ObjectBase
	{
		private DateTime orderDate;
		public DateTime OrderDate
		{
			set { orderDate = value; }
			get { return orderDate; }
		}

		private int orderNumber;
		public int OrderNumber
		{
			set { orderNumber = value; }
			get { return orderNumber; }
		}

		private OrderStatusEnum orderStatus;
		public OrderStatusEnum OrderStatus
		{
			set { orderStatus = value; }
			get { return orderStatus; }
		}
	}
}
