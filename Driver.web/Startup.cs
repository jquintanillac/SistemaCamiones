using Driver.web.Data;
using Driver.web.IServices;
using Driver.web.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   

namespace Driver.web
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
            services.AddDbContext<Datacontext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options => { options.LoginPath = "/Login"; });
            services.AddSingleton<IConfiguration>(this.Configuration);
            services.AddSession(o =>
            {
                o.IdleTimeout = TimeSpan.FromSeconds(1800);
            });
            services.AddScoped<IMDcargaServices, MDcargaService>();
            services.AddScoped<IMDChoferServices, MDChoferService>();
            services.AddScoped<IMDClienteServices, MDClienteService>();
            services.AddScoped<IMDDocumento_CabeceraServices, MDDocumento_CabeceraService>();
            services.AddScoped<IMDDocumento_DetalleServices, MDDocumento_DetalleService>();                        
            services.AddScoped<IMDEstadosServices, MDEstadosService>();
            services.AddScoped<IMDMantenimiento_PredictivoServices, MDMantenimiento_PredictivoService>();
            services.AddScoped<IMDMenuServices, MDMenuService>();
            services.AddScoped<IMDProveedorServices, MDProveedorService>();
            services.AddScoped<IMDRepuestosServices, MDRepuestosService>();
            services.AddScoped<IMDRepuestos_CamionServices, MDRepuestos_CamionService>();
            services.AddScoped<IMDRolServices, MDRolService>();
            services.AddScoped<IMDRol_PermisosServices, MDRol_PermisosService>();
            services.AddScoped<IMDRol_UsuarioServices, MDRol_UsuarioService>();
            services.AddScoped<IMDServicio_CabeceraServices, MDServicio_CabeceraService>();
            services.AddScoped<IMDServicio_DetalleServices, MDServicio_DetalleService>();
            services.AddScoped<IMDSubmenuServices, MDSubmenuService>();
            services.AddScoped<IMDTipo_documentoServices, MDTipo_documentoService>();
            services.AddScoped<IMDTransportistaServices, MDTransportistaService>();
            services.AddScoped<IMDUbigeoServices, MDUbigeoService>();
            services.AddScoped<IMDUsuarioServices, MDUsuarioService>();
            services.AddScoped<IMDViaticos_CabeceraServices, MDViaticos_CabeceraService>();
            services.AddScoped<IMDViaticos_DetalleServices, MDViaticos_DetalleService>();
            services.AddScoped<IMDGrifoServices, MDGrifoService>();
            services.AddScoped<IMDMarcaServices, MDMarcaService>();
            services.AddScoped<IMDModeloServices, MDModeloService>();
            services.AddScoped<IMDTipo_camionServices, MDTipo_camionService>();
            services.AddScoped<IMDTipo_semiremolqueServices, MDTipo_semiremolqueService>();
            services.AddScoped<IMDVehiculoServices, MDVehiculoService>();
            services.AddScoped<IMDCondicion_ContractualServices, MDCondicion_ContractualService>();
            services.AddScoped<IMDEspecialidadServices, MDEspecialidadService>();
            services.AddScoped<IMDGeneralesServices, MDGeneralesService>();
            services.AddScoped<IMDTipo_empleServices, MDTipo_empleService>();
            services.AddScoped<IMDTipo_licenciaServices, MDTipo_licenciaService>();
            services.AddScoped<IMDInventarioServices, MDInventarioService>();
            services.AddScoped<IMDProcesoServices, MDProcesoService>();
            services.AddScoped<IMDProceso_EstadoServices, MDProceso_EstadoService>();
            services.AddScoped<IMDProceso_VehiculoServices, MDProceso_VehiculoService>();
            services.AddScoped<IMDProceso_VehiculoDetalle, MDProceso_VehiculoDetalleService>();
            services.AddScoped<IMDCombustibleServices, MDCombustibleService>();
            services.AddScoped<IMDProductoServices, MDProductoService>();
            services.AddScoped<IMDRepuestos_TercerosServices, MDRepuestos_TercerosService>();
            services.AddScoped<IMDLiquidacionServices, MDLiquidacionService>();
            services.AddScoped<IMDFactura_cabeceraServices, MDFactura_CabeceraService>();
            services.AddScoped<IMDTipo_servicioServices, MDTipo_servicioService>();
            services.AddControllersWithViews()
                .AddJsonOptions(o =>{
                    o.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                    o.JsonSerializerOptions.PropertyNamingPolicy = null;
            });            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
