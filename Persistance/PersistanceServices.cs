using Microsoft.Extensions.DependencyInjection;
using Persistance.DataAccess;

namespace Persistance;

public static class PersistanceServices
{
	public static IServiceCollection AddPersistanceServices(this IServiceCollection services)
	{
		services.AddScoped<IDataAccess, DemoDataAccess>();

		return services;
	}
}
