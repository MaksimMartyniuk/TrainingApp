using AbstractDataLayer.BusinessObjects;

namespace AbstractDataLayer.Factories
{
	public class PassportFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new Passport();
		}
	}
}
