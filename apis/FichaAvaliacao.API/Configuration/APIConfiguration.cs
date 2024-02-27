
using Microsoft.AspNetCore.Mvc;

using FichaAvaliacao.API.Configuration.Model;
using FichaAvaliacao.API.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace FichaAvaliacao.API.Configuration
{
    public static class APIConfiguration
    {
        public static void AddApiConfigurationFichaAvaliacao(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddControllers();
            services.AddDbContext<BDContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();

            services.AddCors(options =>
            {
                options.AddPolicy("Total",
                    builder =>
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
            });
        }

        public static void UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("Total");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
