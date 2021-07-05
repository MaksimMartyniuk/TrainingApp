using System;
using System.ComponentModel.DataAnnotations;
using TrainingApp.Enums;

namespace TrainingApp.BusinessObjects
{
	public class Order
	{
		public Guid Id { get; private set; }

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
