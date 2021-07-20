using Microsoft.Extensions.Configuration;

namespace TrainingApp
{
	/*
		Разбить на отдельные прокты, типо DataLayer, DataLayer.JSON, DataLayer
		Factory->Repository->Context есть фабрика, которая создает репозитории, которые создают контескты,
		при этом строка отправляется в фабрику, а фабрика создает репозитории со строкой
	*/
	class Program
	{
		static void Main(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.Build();

		}
	}
}
