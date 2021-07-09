using DataLayer.BusinessObjects;

namespace DataLayer.Factories
{
	public class UserFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new User();
		}
	}
}
