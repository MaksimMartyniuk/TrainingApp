namespace AbstractDataLayer.BusinessObjects
{
	public class User : ObjectBase
	{
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
