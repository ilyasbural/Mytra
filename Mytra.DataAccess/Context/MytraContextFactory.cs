namespace Mytra.DataAccess
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Design;
	using Microsoft.Extensions.Configuration;

	public class MytraContextFactory : IDesignTimeDbContextFactory<MytraContext>
	{
		public MytraContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<MytraContext>();
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			var connectionString = configuration.GetConnectionString("SqlServer");
			builder.UseSqlServer(connectionString);
			return new MytraContext(builder.Options);
		}
	}
}