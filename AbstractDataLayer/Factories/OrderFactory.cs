using DataLayer.BusinessObjects;

namespace DataLayer.Factories
{
	public class OrderFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new Order();
		}
	}
}
