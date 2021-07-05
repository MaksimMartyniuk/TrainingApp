using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TrainingApp.BusinessObjects;

namespace TrainingApp.Repositories.MSSQL
{
	public class MSSQLContext : DbContext
	{
		public MSSQLContext()
		{
			this.Database.EnsureCreated();
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Passport> Passports { get; set; }
		public DbSet<Order> Orders { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.Build();

			optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultSQLConnection"));
		}
	}
}
