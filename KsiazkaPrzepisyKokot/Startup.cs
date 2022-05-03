using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KsiazkaPrzepisyKokot.Database;
using KsiazkaPrzepisyKokot.Repository.Interfaces;
using KsiazkaPrzepisyKokot.UnitOfWork;
using KsiazkaPrzepisyKokot.BuisnessLayer.Interface;
using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using Microsoft.OpenApi.Models;
using Swashbuckle.Swagger;

namespace KsiazkaPrzepisyKokot
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(c =>
            {
                c.AddPolicy(
                name: "AllowOrigin",
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
            
                   
            services.AddDbContext<BazaDanych>();

            services.AddScoped<UnitOfWork_>();
            services.AddScoped<SkladnikiPrzepisuBL>();
            services.AddScoped<UlubioneBL>();
            services.AddScoped<LogBL>();
            services.AddScoped<PrzepisyBL>();
            services.AddScoped<WszystkieSkladnikiBL>();      
            services.AddScoped<KompletnyPrzepisBL>();
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                //c.SwaggerDoc("v1", new OpenApiInfo { Title = "KsiazkaPrzepisyKokot", Version = "v1" });
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API WSVAP (WebSmartView)", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line

        });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseDeveloperExceptionPage();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("./v1/swagger.json", "My API V1")); //originally "./swagger/v1/swagger.json"
               // app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "KsiazkaPrzepisyKokot v1"));

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseRouting();

            app.UseCors("AllowOrigin");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
