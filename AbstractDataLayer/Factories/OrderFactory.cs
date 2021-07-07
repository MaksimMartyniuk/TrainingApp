using AbstractDataLayer.BusinessObjects;

namespace AbstractDataLayer.Factories
{
	public class OrderFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new Order();
		}
	}
}
