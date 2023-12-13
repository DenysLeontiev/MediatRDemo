using Microsoft.Extensions.DependencyInjection;
using Persistance.DataAccess;
using System.Reflection;

namespace Persistance;

public static class PersistanceServiceRegistration
{
	public static IServiceCollection AddPersistanceServices(this IServiceCollection services)
	{
		services.AddScoped<IDataAccess, DemoDataAccess>();
		services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

		return services;
	}
}
