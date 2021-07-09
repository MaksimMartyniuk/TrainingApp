using DataLayer.BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.MSSQL
{
	public class MSSQLContext : DbContext
	{
		private string connectionString;
		public MSSQLContext(string conn)
		{
			connectionString = conn;
			this.Database.EnsureCreated();
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Passport> Passports { get; set; }
		public DbSet<Order> Orders { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
