using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consulcon.API.Controllers
{
    // Financial & Documents
    public class ContratoController : CrudController<Contrato> { public ContratoController(IRepository<Contrato> r) : base(r) { } }
    public class DeudaController : CrudController<Deuda> { public DeudaController(IRepository<Deuda> r) : base(r) { } }
    public class CuotaController : CrudController<Cuota> { public CuotaController(IRepository<Cuota> r) : base(r) { } }
    public class EgresoController : CrudController<Egreso> { public EgresoController(IRepository<Egreso> r) : base(r) { } }
    public class ReciboEgresoController : CrudController<Reciboegreso> { public ReciboEgresoController(IRepository<Reciboegreso> r) : base(r) { } }
    
    // Configuration & Catalogs
    public class MonedaController : CrudController<Moneda> { public MonedaController(IRepository<Moneda> r) : base(r) { } }
    public class ManzanoController : CrudController<Manzano> { public ManzanoController(IRepository<Manzano> r) : base(r) { } }
    public class TipoUsuarioController : CrudController<Tipousuario> { public TipoUsuarioController(IRepository<Tipousuario> r) : base(r) { } }
    public class FormPagoController : CrudController<Formpago> { public FormPagoController(IRepository<Formpago> r) : base(r) { } }
    public class EmpresaController : CrudController<Empresa> { public EmpresaController(IRepository<Empresa> r) : base(r) { } }
    
    // Services
    public class ServicioPagoController : CrudController<Serviciopago> { public ServicioPagoController(IRepository<Serviciopago> r) : base(r) { } }
    public class ServicioCuentaController : CrudController<Serviciocuenta> { public ServicioCuentaController(IRepository<Serviciocuenta> r) : base(r) { } }
    
    // System
    public class EventoController : CrudController<Evento> { public EventoController(IRepository<Evento> r) : base(r) { } }
    public class AutorizacionController : CrudController<Autorizacion> { public AutorizacionController(IRepository<Autorizacion> r) : base(r) { } }
    public class AvisoCobranzaController : CrudController<Avisoconbranza> { public AvisoCobranzaController(IRepository<Avisoconbranza> r) : base(r) { } }
    
}
