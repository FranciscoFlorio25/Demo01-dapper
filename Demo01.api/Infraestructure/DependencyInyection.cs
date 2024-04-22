using Demo01.api.Infraestructure.Context;
using Demo01.api.Services.Data.Context;

namespace Demo01.api.Infraestructure
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {
            services.AddScoped<IDapperContext, DapperContext>();
            return services;
        }
    }
}
