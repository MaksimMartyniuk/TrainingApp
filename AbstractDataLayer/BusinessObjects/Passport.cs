using System;

namespace DataLayer.BusinessObjects
{
	public class Passport : ObjectBase
	{
		private string series;
		public string Series
		{
			set { series = value; }
			get { return series; }
		}

		private int number;
		public int Number
		{
			set { number = value; }
			get { return number; }
		}

		private string idNumber;
		public string IdNumber
		{
			set { idNumber = value; }
			get { return idNumber; }
		}

		private DateTime dateOfIssue;
		public DateTime DateOfIssue
		{
			set { dateOfIssue = value; }
			get { return dateOfIssue; }
		}

		private DateTime dateOfExpiry;
		public DateTime DateOfExpiry
		{
			set { dateOfExpiry = value; }
			get { return dateOfExpiry; }
		}
	}
}
