using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AuthServer.Infrastructure;

public static class DatabaseExtensionMethods
{
	public static void ConfigureDatabase(this IServiceCollection services, string connectionString)
	{
		services.AddDbContext<DbContext>(
			options => options.UseSqlServer(connectionString)
		);
	}
}
