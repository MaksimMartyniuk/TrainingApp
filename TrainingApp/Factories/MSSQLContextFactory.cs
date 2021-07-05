using TrainingApp.Repositories.MSSQL;

namespace TrainingApp.Factories
{
	public class MSSQLContextFactory : IFactory<MSSQLContext>
	{
		public MSSQLContext Create()
		{
			return new MSSQLContext();
		}
	}
}
