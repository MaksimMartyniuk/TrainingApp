using DataLayer.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataLayer.JSON.Entities
{
	public class User : IUser
	{
		[JsonPropertyName("id")]
		public Guid Id { get; set; }

		[JsonPropertyName("first-name")]
		public string FirstName { get; set; }

		[JsonPropertyName("mindle-name")]
		public string MindleName { get; set; }

		[JsonPropertyName("last-name")]
		public string LastName { get; set; }

		[JsonPropertyName("age")]
		public int Age { get; set; }

		[JsonPropertyName("passport")]
		public IPassport Passport { get; set; }

		[JsonPropertyName("orders")]
		public IEnumerable<IOrder> Orders { get; set; }
	}
}