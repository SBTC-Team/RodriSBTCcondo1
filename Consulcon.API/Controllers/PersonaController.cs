using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;

namespace Consulcon.API.Controllers
{
    public class PersonaController : CrudController<Persona>
    {
        public PersonaController(IRepository<Persona> repository) : base(repository) { }
    }
}
