using TrainingApp.BusinessObjects;

namespace TrainingApp.Factories
{
	public class PassportFactory : IBusinessObjectFactory<ObjectBase>
	{
		public ObjectBase Create()
		{
			return new Passport();
		}
	}
}
