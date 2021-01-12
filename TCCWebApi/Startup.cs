using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using TCCWebApi.Data;
using TCCWebApi.Data.Interfaces;
using TCCWebApi.Data.Services;
using TCCWebApi.Data.Services.Interfaces;

namespace TCCWebApi
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
            
            services.AddControllers();
             services.AddDbContext<Context>(
                opt => opt.UseSqlServer(
                    Configuration.GetConnectionString("ConexaoBase")
                )
            );

            services.AddScoped<IRepositorio, Repositorio>();
            services.AddScoped<IRepositorioIngrediente, RepositorioIngrediente>();
            services.AddScoped<IRepositorioIngredienteProduto, RepositorioIngredienteProduto>();
            services.AddScoped<IRepositorioModoPreparo, RepositorioModoPreparo>();
            services.AddScoped<IRepositorioModoPreparoItem, RepositorioModoPreparoItem>();
            services.AddScoped<IRepositorioProduto, RepositorioProduto>();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TCCWebApi", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TCCWebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
