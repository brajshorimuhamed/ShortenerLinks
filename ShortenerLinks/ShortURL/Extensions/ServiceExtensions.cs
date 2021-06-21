using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShortenerLinks.Models.Contexts;
using ShortenerLinks.Models.Entities.Repositories;
using ShortenerLinks.Models.Entities.Repositories.Repository_Abstracts;
using ShortenerLinks.Models.Entities.Services;
using ShortenerLinks.Models.Entities.Services.Service_Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.ShortURL.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }
        

        public static void RegisterDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            string shortLinkDataStore = Configuration.GetConnectionString("ShortLinkDatabase");
            services.AddDbContext<ShortLinkDbContext>(options => options.UseSqlServer(shortLinkDataStore));
            services.AddTransient<IRepostory, ShortURLRepository>();
            services.AddScoped<IShortUrlService, ShortLinkService>();
        }
    }
}
