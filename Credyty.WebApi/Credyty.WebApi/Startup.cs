using Catalog.Persistence.Database;
using Credyty.Logic.Implementacion;
using Credyty.Logic.Interfaces;
using Credyty.Repository.Implementacion;
using Credyty.Repository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Credyty.WebApi
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

            // DbContext
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")
                )
            );

            services.AddControllers();


            // Agregar inyeccion
            services.AddTransient<IClienteLogic, ClienteLogic>();
            services.AddTransient<ICuentaAhorroLogic, CuentaAhorroLogic>();
            services.AddTransient<IMovimientoCuentaLogic, MovimientoCuentaLogic>();

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<ICuentaAhorroRepository, CuentaAhorroRepository>();
            services.AddTransient<IMovimientoCuentaRepository, MovimientoCuentaRepository>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
