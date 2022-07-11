using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BodyMassIndex.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistration).Assembly);
            services.AddFluentValidation(conf =>
            {
                conf.RegisterValidatorsFromAssembly(typeof(ServiceRegistration).Assembly);
            });
        }
    }
}
