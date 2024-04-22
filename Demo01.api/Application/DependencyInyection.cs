using Demo01.api.Application.Repository;
using Demo01.api.Infraestructure.Context;
using Demo01.api.Services.Data.Context;
using Demo01.api.Services.Data.Repository;

namespace Demo01.api.Application
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
