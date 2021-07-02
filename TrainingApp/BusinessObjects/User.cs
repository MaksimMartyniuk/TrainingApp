using System;

namespace TrainingApp.BusinessObjects
{
	public class User
	{
		private Guid id = new();
		public Guid Id
		{
			get { return id; }
		}

		private string firstName;
		public string FirstName
		{
			set { firstName = value; }
			get { return firstName; }
		}

		private string mindleName;
		public string MindleName
		{
			set { mindleName = value; }
			get { return mindleName; }
		}

		private string lastName;
		public string LastName
		{
			set { lastName = value; }
			get { return lastName; }
		}

		private int age;
		public int Age
		{
			set { age = value; }
			get { return age; }
		}
	}
}
