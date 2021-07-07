namespace AbstractDataLayer.Factories
{
	public interface IBusinessObjectFactory<T>
	{
		public T Create();
	}
}
