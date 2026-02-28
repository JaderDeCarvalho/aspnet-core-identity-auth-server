using Microsoft.Extensions.DependencyInjection;
using AuthServer.Domain.Repositories;
using AuthServer.Infrastructure.Data.Repositories;
using AuthService.Application.Services.Interfaces;
using AuthServer.Application.Services;

namespace AuthServer.Infrastructure.IoC;

public static class DependencyInjection
{
	public static void InjectCustomServices(this IServiceCollection services)
	{
		services.AddScoped<IUserService, UserService>();
	}

	public static void InjectCustomRepositories(this IServiceCollection services)
	{
		services.AddScoped<IUserRepository, UserRepository>();
	}
}
