using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;

namespace Consulcon.API.Controllers
{
    public class AsientoController : CrudController<Asiento>
    {
        public AsientoController(IRepository<Asiento> repository) : base(repository) { }
    }
}
