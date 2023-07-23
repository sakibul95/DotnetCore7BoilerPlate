using Infrastructure.Helpers.DataContext;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Extension
{
    public static class ServiceExtensions
    {
        public static void CorsConfiguration(this IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
        }
        public static void ConfigDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            
        }
    }
}
