using Core.Services;
using DataLayer;
using DataLayer.Repositories;

namespace Project.Settings
{
    public static class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            applicationBuilder.Services.AddSingleton<AppDbContext>();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<ApartmentService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<ApartmentsRepository>();
        }
    }
}
