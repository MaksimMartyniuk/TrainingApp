using AbstractDataLayer.BusinessObjects;

namespace AbstractDataLayer.Factories
{
	public class UserFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new User();
		}
	}
}
