using System;
using System.Text.Json.Serialization;
using DataLayer.Enums;
using DataLayer.Interfaces.Entities;

namespace DataLayer.JSON.Entities
{
	public class Order : IOrder
	{
		[JsonPropertyName("id")]
		public Guid Id { get; set; }

		[JsonPropertyName("order-date")]
		public DateTime OrderDate { get; set; }

		[JsonPropertyName("order-number")]
		public int OrderNumber { get; set; }

		[JsonPropertyName("order-status-enum")]
		[JsonConverter(typeof(JsonStringEnumConverter))]
		public OrderStatusEnum OrderStatus { get; set; }

		[JsonPropertyName("user")]
		public IUser User { get; set; }
	}
}