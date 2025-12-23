using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consulcon.API.Controllers
{
    // Detailed & Auxiliary Entities
    public class ConfAvisoController : CrudController<Confaviso> { public ConfAvisoController(IRepository<Confaviso> r) : base(r) { } }
    public class ConfEjecucionController : CrudController<Confejecucion> { public ConfEjecucionController(IRepository<Confejecucion> r) : base(r) { } }
    public class ConfEjecucionTituloController : CrudController<Confejecuciontitulo> { public ConfEjecucionTituloController(IRepository<Confejecuciontitulo> r) : base(r) { } }
    public class ConfiguracionEventoController : CrudController<Configuracionevento> { public ConfiguracionEventoController(IRepository<Configuracionevento> r) : base(r) { } }
    
    public class CorreoController : CrudController<Correo> { public CorreoController(IRepository<Correo> r) : base(r) { } }
    public class CuentaController : CrudController<Cuenta> { public CuentaController(IRepository<Cuenta> r) : base(r) { } }
    public class CuentaSistemaController : CrudController<Cuentasistema> { public CuentaSistemaController(IRepository<Cuentasistema> r) : base(r) { } }
    
    public class DetalleAsientoController : CrudController<Detalleasiento> { public DetalleAsientoController(IRepository<Detalleasiento> r) : base(r) { } }
    public class DetalleConfEjecucionController : CrudController<Detalleconfejecucion> { public DetalleConfEjecucionController(IRepository<Detalleconfejecucion> r) : base(r) { } }
    
    public class OpcionCobroController : CrudController<Opcioncobro> { public OpcionCobroController(IRepository<Opcioncobro> r) : base(r) { } }
    public class PermisoController : CrudController<Permiso> { public PermisoController(IRepository<Permiso> r) : base(r) { } }
    
    public class PersonaContratoController : CrudController<PersonaContrato> { public PersonaContratoController(IRepository<PersonaContrato> r) : base(r) { } }
    public class ProveedorController : CrudController<Proveedor> { public ProveedorController(IRepository<Proveedor> r) : base(r) { } }
    
    public class ReciboGeneralController : CrudController<Recibogeneral> { public ReciboGeneralController(IRepository<Recibogeneral> r) : base(r) { } }
    public class ReciboPersonalController : CrudController<Recibopersonal> { public ReciboPersonalController(IRepository<Recibopersonal> r) : base(r) { } }
    
    public class ServicioContratoController : CrudController<ServicioContrato> { public ServicioContratoController(IRepository<ServicioContrato> r) : base(r) { } }
    public class TablaServicioController : CrudController<TablaServicio> { public TablaServicioController(IRepository<TablaServicio> r) : base(r) { } }
    
    public class TelefonoController : CrudController<Telefono> { public TelefonoController(IRepository<Telefono> r) : base(r) { } }
    public class TipoPermisoController : CrudController<TipoPermiso> { public TipoPermisoController(IRepository<TipoPermiso> r) : base(r) { } }
    
    public class TtCuotaController : CrudController<Ttcuota> { public TtCuotaController(IRepository<Ttcuota> r) : base(r) { } }
    public class TtDeudaController : CrudController<Ttdeuda> { public TtDeudaController(IRepository<Ttdeuda> r) : base(r) { } }
}
