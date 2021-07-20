using System;

namespace DataLayer.Interfaces.Entities
{
	public interface IPassport : IEntity
	{
		public string Series { get; set; }

		public int Number { get; set; }

		public string IdNumber { get; set; }

		public DateTime DateOfIssue { get; set; }

		public DateTime DateOfExpiry { get; set; }

		public IUser User { get; set; }

	}
}