using DataLayer.Interfaces.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.MSSQL.Entities
{
	[Table("Passport")]
	public class Passport : IPassport
	{
		[Key]
		public Guid Id { get; set; }

		public string Series { get; set; }

		public int Number { get; set; }

		public string IdNumber { get; set; }

		public DateTime DateOfIssue { get; set; }

		public DateTime DateOfExpiry { get; set; }

		//[ForeignKey("User")]
		//public Guid UserId { get; set; }

		public User User { get; set; }

		[NotMapped]
		IUser IPassport.User
		{
			set { User = value as User; }
			get { return User; }
		}
	}
}