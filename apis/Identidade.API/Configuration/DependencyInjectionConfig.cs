using Core.Util.AspNetUser.Interface;
using Core.Util.AspNetUser.Service;
using Core.Util.Email.Interface;
using Core.Util.Email.Service;
using Microsoft.AspNetCore.Identity;

namespace Identidade.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        /// <summary>
        /// Metodo que realizar as dependencias via AddScoped
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IEmailHelper, EmailHelper>();
            services.AddScoped<IAspNetUser, AspNetUser>();
            services.AddSingleton<JwtService>();
            return services;
        }
    }
}
