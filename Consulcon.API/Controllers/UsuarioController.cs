using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;

namespace Consulcon.API.Controllers
{
    public class UsuarioController : CrudController<Usuario>
    {
        public UsuarioController(IRepository<Usuario> repository) : base(repository) { }
    }
}
