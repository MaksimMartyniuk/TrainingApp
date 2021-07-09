using DataLayer.BusinessObjects;

namespace DataLayer.Factories
{
	public class PassportFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new Passport();
		}
	}
}
