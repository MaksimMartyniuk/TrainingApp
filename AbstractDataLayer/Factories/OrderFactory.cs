using TrainingApp.BusinessObjects;

namespace TrainingApp.Factories
{
	public class OrderFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new Order();
		}
	}
}
