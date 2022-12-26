using Driver.web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {
        }
        public virtual DbSet<MDCarga> Carga { get; set; }
        public virtual DbSet<MDChofer> Chofer { get; set; }
        public virtual DbSet<MDCliente> Cliente { get; set; }
        public virtual DbSet<MDDocumento_Cabecera> Documento_Cabecera { get; set; }
        public virtual DbSet<MDDocumento_Detalle> Documento_Detalle { get; set; }
        public virtual DbSet<MDEstados> Estado { get; set; }
        public virtual DbSet<MDRepuestos> Repuesto { get; set; }
        public virtual DbSet<MDRepuestos_Camion> Repuesto_Camion { get; set; }
        public virtual DbSet<MDRol> Rol { get; set; }
        public virtual DbSet<MDRol_Usuario> Rol_Usuario { get; set; }
        public virtual DbSet<MDServicio_Cabecera> Servicio_Cabecera { get; set; }
        public virtual DbSet<MDServicio_Detalle> Servicio_Detalle { get; set; }
        public virtual DbSet<MDTipo_documento> Tipo_Documento { get; set; }
        public virtual DbSet<MDTransportista> Transportista { get; set; }
        public virtual DbSet<MDUbigeo> Ubigeo { get; set; }
        public virtual DbSet<MDUsuario> Usuario { get; set; }
        public virtual DbSet<MDMenu> Menus { get; set; }
        public virtual DbSet<MDSubmenu> Submenus { get; set; }
        public virtual DbSet<MDRol_Permisos> Rol_Permisos { get; set; }       
        public virtual DbSet<MDProveedor> Proveedor { get; set; }
        public virtual DbSet<MDMantenimiento_Predictivo> Mantenimiento_Predictivo { get; set; }
        public virtual DbSet<MDViaticos_Cabecera> Viaticos_Cabecera { get; set; }
        public virtual DbSet<MDViaticos_Detalle> Viaticos_Detalle { get; set; }
        public virtual DbSet<MDGrifo> Grifos { get; set; }
        public virtual DbSet<MDCombustible> Combustibles { get; set; }
        public virtual DbSet<MDLiquidacion> Liquidaciones { get; set; }
        public virtual DbSet<MDFactura_Cabecera> Factura_Cabeceras { get; set; }
        public virtual DbSet<MDCondicion_Contractual> Condicion_Contractuales { get; set; }
        public virtual DbSet<MDEspecialidad> Especialidades { get; set; }
        public virtual DbSet<MDGenerales> Generales { get; set; }
        public virtual DbSet<MDTipo_camion> Tipo_Camiones { get; set; }
        public virtual DbSet<MDTipo_licencia> Tipo_Licencias { get; set; }
        public virtual DbSet<MDTipo_emple> Tipo_Emples { get; set; }
        public virtual DbSet<MDVehiculo> Vehiculos { get; set; }
        public virtual DbSet<MDModelo> Modelos { get; set; }
        public virtual DbSet<MDMarca> Marcas { get; set; }
        public virtual DbSet<MDTipo_Semiremolque> Tipo_Semiremolques { get; set; }
        public virtual DbSet<MDInventario> Inventarios { get; set; }
        public virtual DbSet<MDProceso> Procesos { get; set; }
        public virtual DbSet<MDProceso_Estado> Proceso_Estados { get; set; }
        public virtual DbSet<MDProceso_Vehiculo> Proceso_Vehiculos { get; set; }
        public virtual DbSet<MDProceso_VehiculoDetalle> Proceso_VehiculoDetalles { get; set; }
        public virtual DbSet<MDProducto> Productos { get; set; }
        public virtual DbSet<MDRepuestos_Terceros> Repuestos_Terceros { get; set; }
        public virtual DbSet<MDEventos> Eventos { get; set; }
        public virtual DbSet<MDTipo_servicio> Tipo_Servicios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MDUsuario>()
            .HasIndex(t => t.Usua_user)
            .IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MDTransportista>()
            .HasIndex(t => t.transp_doc)
            .IsUnique();


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MDCliente>()
            .HasIndex(t => t.clie_dociden)
            .IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MDCarga>()
            .HasIndex(t => t.carg_desc)
            .IsUnique();

        }

    }
}
