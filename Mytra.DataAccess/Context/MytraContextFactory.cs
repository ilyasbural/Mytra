namespace Mytra.DataAccess
{
	using Microsoft.Extensions.Configuration;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Design;

	public class MytraContextFactory : IDesignTimeDbContextFactory<MytraContext>
	{
		public MytraContext CreateDbContext(string[] args)
		{
			var Builder = new DbContextOptionsBuilder<MytraContext>();
			IConfigurationRoot Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
			var ConnectionString = Configuration.GetConnectionString("SqlServer");
			Builder.UseSqlServer(ConnectionString);
			return new MytraContext(Builder.Options);
		}
	}
}