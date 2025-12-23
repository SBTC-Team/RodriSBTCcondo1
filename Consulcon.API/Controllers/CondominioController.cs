using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;

namespace Consulcon.API.Controllers
{
    public class CondominioController : CrudController<Condominio>
    {
        public CondominioController(IRepository<Condominio> repository) : base(repository) { }
    }
}
