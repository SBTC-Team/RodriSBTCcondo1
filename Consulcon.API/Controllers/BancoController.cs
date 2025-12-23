using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;

namespace Consulcon.API.Controllers
{
    public class BancoController : CrudController<Banco>
    {
        public BancoController(IRepository<Banco> repository) : base(repository) { }
    }
}
