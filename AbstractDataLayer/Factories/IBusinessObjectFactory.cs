namespace DataLayer.Factories
{
	public interface IBusinessObjectFactory<T>
	{
		public T Create();
	}
}
