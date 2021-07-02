using System;
using TrainingApp.Enums;

namespace TrainingApp.BusinessObjects
{
	public class Order
	{
		private Guid id = new();
		public Guid Id
		{
			get { return id; }
		}

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
