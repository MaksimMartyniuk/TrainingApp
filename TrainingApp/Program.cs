using Microsoft.Extensions.Configuration;
using System;

namespace TrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            Console.WriteLine(connectionString);

            Console.ReadKey();
        }
    }
}
