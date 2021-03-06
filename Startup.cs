using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeSalasBackEnd.Models;
using ControleDeSalasBackEnd.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ControleDeSalasBackEnd
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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowed((host) => true)
                        .AllowAnyHeader());
            });            

            services.AddControllers();

            // Conex�o com o Banco de Dados e retorna os registros existentes na tabela Salas
            services.AddDbContext<SalasDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));            
            services.AddTransient<ISalasRepository, SalaRepository>();

            // Conex�o com o Banco de Dados e retorna os registros existentes na tabela Agendamentos
            services.AddDbContext<AgendamentosDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAgendamentosRepository, AgendamentosRepository>();

            // Conex�o com o Banco de Dados e retorna os registros existentes na tabela Agendamentos fazendo right join com Salas
            services.AddDbContext<AgendamentosEndSalasDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAgendamentosEndSalasRepository, AgendamentosEndSalasRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
