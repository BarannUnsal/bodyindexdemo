using BodyMassIndex.Application.Repositories;
using BodyMassIndex.Persistence.Context;
using BodyMassIndex.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BodyMassIndex.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BodyMassIndexDb>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IDimensionsRepository, DimensionsRepository>();
        }
    }
}
