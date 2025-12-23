using Microsoft.EntityFrameworkCore;
using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;

namespace Consulcon.Infrastructure.Persistence
{
    public class ConsulconDbContext : DbContext
    {
        private readonly ICurrentTenantService _currentTenantService;

        public ConsulconDbContext(DbContextOptions<ConsulconDbContext> options, ICurrentTenantService currentTenantService) : base(options)
        {
            _currentTenantService = currentTenantService;
        }

        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Autorizacion> Autorizacions { get; set; }
        public DbSet<Avisoconbranza> Avisoconbranzas { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Confaviso> Confavisos { get; set; }
        public DbSet<Confejecucion> Confejecucions { get; set; }
        public DbSet<Confejecuciontitulo> Confejecuciontitulos { get; set; }
        public DbSet<Configuracionevento> Configuracioneventos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Correo> Correos { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Cuentasistema> Cuentasistemas { get; set; }
        public DbSet<Cuota> Cuotas { get; set; }
        public DbSet<Detalleasiento> Detalleasientos { get; set; }
        public DbSet<Detalleconfejecucion> Detalleconfejecucions { get; set; }
        public DbSet<Deuda> Deudas { get; set; }
        public DbSet<Egreso> Egresos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Formpago> Formpagos { get; set; }
        public DbSet<Manzano> Manzanos { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Opcioncobro> Opcioncobros { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<PersonaContrato> PersonaContratos { get; set; }
        public DbSet<Propiedad> Propiedads { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Reciboegreso> Reciboegresos { get; set; }
        public DbSet<Recibogeneral> Recibogenerals { get; set; }
        public DbSet<Recibopersonal> Recibopersonals { get; set; }
        public DbSet<Serviciocuenta> Serviciocuentas { get; set; }
        public DbSet<Serviciopago> Serviciopagos { get; set; }
        public DbSet<ServicioContrato> ServicioContratos { get; set; }
        public DbSet<TablaServicio> TablaServicios { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Tipousuario> Tipousuarios { get; set; }
        public DbSet<TipoPermiso> TipoPermisos { get; set; }
        public DbSet<Ttcuota> Ttcuotas { get; set; }
        public DbSet<Ttdeuda> Ttdeudas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Asiento>(entity =>
            {
                entity.ToTable("asiento");
                entity.HasKey(e => e.PkAsiento);
            });

            modelBuilder.Entity<Autorizacion>(entity =>
            {
                entity.ToTable("autorizacion");
                entity.HasKey(e => e.PkAutorizacion);
            });

            modelBuilder.Entity<Avisoconbranza>(entity =>
            {
                entity.ToTable("avisoconbranza");
                entity.HasKey(e => e.PkAvisoconbranza);
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.ToTable("banco");
                entity.HasKey(e => e.PkBanco);
            });

            modelBuilder.Entity<Condominio>(entity =>
            {
                entity.ToTable("condominio");
                entity.HasKey(e => e.PkCondominio);
            });

            modelBuilder.Entity<Contrato>().HasQueryFilter(e => _currentTenantService.TenantId == null || e.FkCondominio == int.Parse(_currentTenantService.TenantId));
            modelBuilder.Entity<Propiedad>().HasQueryFilter(e => _currentTenantService.TenantId == null || e.FkCondominio == int.Parse(_currentTenantService.TenantId));


            modelBuilder.Entity<Confaviso>(entity =>
            {
                entity.ToTable("confaviso");
                entity.HasKey(e => e.PkConfaviso);
            });

            modelBuilder.Entity<Confejecucion>(entity =>
            {
                entity.ToTable("confejecucion");
                entity.HasKey(e => e.PkConfejecucion);
            });

            modelBuilder.Entity<Confejecuciontitulo>(entity =>
            {
                entity.ToTable("confejecuciontitulo");
                entity.HasKey(e => e.PkConfejecuciontitulo);
            });

            modelBuilder.Entity<Configuracionevento>(entity =>
            {
                entity.ToTable("configuracionevento");
                entity.HasNoKey();
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.ToTable("contrato");
                entity.HasKey(e => e.PkContrato);
            });

            modelBuilder.Entity<Correo>(entity =>
            {
                entity.ToTable("correo");
                entity.HasKey(e => e.PkCorreo);
            });

            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.ToTable("cuenta");
                entity.HasKey(e => e.PkCuenta);
            });

            modelBuilder.Entity<Cuentasistema>(entity =>
            {
                entity.ToTable("cuentasistema");
                entity.HasKey(e => e.PkCuentasistema);
            });

            modelBuilder.Entity<Cuota>(entity =>
            {
                entity.ToTable("cuota");
                entity.HasKey(e => e.PkCuota);
            });

            modelBuilder.Entity<Detalleasiento>(entity =>
            {
                entity.ToTable("detalleasiento");
                entity.HasKey(e => e.PkDetalleasiento);
            });

            modelBuilder.Entity<Detalleconfejecucion>(entity =>
            {
                entity.ToTable("detalleconfejecucion");
                entity.HasKey(e => e.PkCuenta);
            });

            modelBuilder.Entity<Deuda>(entity =>
            {
                entity.ToTable("deuda");
                entity.HasKey(e => e.PkDeuda);
            });

            modelBuilder.Entity<Egreso>(entity =>
            {
                entity.ToTable("egreso");
                entity.HasKey(e => e.PkEgreso);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("empresa");
                entity.HasKey(e => e.PkEmpresa);
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.ToTable("evento");
                entity.HasKey(e => e.PkEvento);
            });

            modelBuilder.Entity<Formpago>(entity =>
            {
                entity.ToTable("formpago");
                entity.HasKey(e => e.PkFormpago);
            });

            modelBuilder.Entity<Manzano>(entity =>
            {
                entity.ToTable("manzano");
                entity.HasKey(e => e.PkManzano);
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.ToTable("moneda");
                entity.HasKey(e => e.PkMoneda);
            });

            modelBuilder.Entity<Opcioncobro>(entity =>
            {
                entity.ToTable("opcioncobro");
                entity.HasKey(e => e.PkOpcioncobro);
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.ToTable("permiso");
                entity.HasKey(e => e.PkPermiso);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona");
                entity.HasKey(e => e.PkPersona);
            });

            modelBuilder.Entity<PersonaContrato>(entity =>
            {
                entity.ToTable("persona_contrato");
                entity.HasNoKey();
            });

            modelBuilder.Entity<Propiedad>(entity =>
            {
                entity.ToTable("propiedad");
                entity.HasKey(e => e.PkPropiedad);
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.ToTable("proveedor");
                entity.HasKey(e => e.PkProveedor);
            });

            modelBuilder.Entity<Reciboegreso>(entity =>
            {
                entity.ToTable("reciboegreso");
                entity.HasKey(e => e.PkReciboegreso);
            });

            modelBuilder.Entity<Recibogeneral>(entity =>
            {
                entity.ToTable("recibogeneral");
                entity.HasKey(e => e.PkRecibogeneral);
            });

            modelBuilder.Entity<Recibopersonal>(entity =>
            {
                entity.ToTable("recibopersonal");
                entity.HasKey(e => e.PkRecibopersonal);
            });

            modelBuilder.Entity<Serviciocuenta>(entity =>
            {
                entity.ToTable("serviciocuenta");
                entity.HasKey(e => e.PkServiciocuenta);
            });

            modelBuilder.Entity<Serviciopago>(entity =>
            {
                entity.ToTable("serviciopago");
                entity.HasKey(e => e.PkServiciopago);
            });

            modelBuilder.Entity<ServicioContrato>(entity =>
            {
                entity.ToTable("servicio_contrato");
                entity.HasKey(e => e.PkServicioContrato);
            });

            modelBuilder.Entity<TablaServicio>(entity =>
            {
                entity.ToTable("tabla_servicio");
                entity.HasKey(e => e.PkContrato);
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.ToTable("telefono");
                entity.HasKey(e => e.PkTelefono);
            });

            modelBuilder.Entity<Tipousuario>(entity =>
            {
                entity.ToTable("tipousuario");
                entity.HasKey(e => e.PkTipousuario);
            });

            modelBuilder.Entity<TipoPermiso>(entity =>
            {
                entity.ToTable("tipo_permiso");
                entity.HasNoKey();
            });

            modelBuilder.Entity<Ttcuota>(entity =>
            {
                entity.ToTable("ttcuota");
                entity.HasKey(e => e.PkCuota);
            });

            modelBuilder.Entity<Ttdeuda>(entity =>
            {
                entity.ToTable("ttdeuda");
                entity.HasKey(e => e.PkDeuda);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");
                entity.HasKey(e => e.PkUsuario);
            });


        }
    }
}
