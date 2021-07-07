using TrainingApp.BusinessObjects;

namespace TrainingApp.Factories
{
	public class UserFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new User();
		}
	}
}
