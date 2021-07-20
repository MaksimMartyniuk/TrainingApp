using DataLayer.Interfaces.Entities;
using System;
using System.Text.Json.Serialization;

namespace DataLayer.JSON.Entities
{
	public class Passport : IPassport
	{
		[JsonPropertyName("id")]
		public Guid Id { get; set; }

		[JsonPropertyName("series")]
		public string Series { get; set; }

		[JsonPropertyName("number")]
		public int Number { get; set; }

		[JsonPropertyName("id-number")]
		public string IdNumber { get; set; }

		[JsonPropertyName("date-of-issue")]
		public DateTime DateOfIssue { get; set; }

		[JsonPropertyName("date-of-expiry")]
		public DateTime DateOfExpiry { get; set; }

		[JsonPropertyName("user")]
		public IUser User { get; set; }
	}
}