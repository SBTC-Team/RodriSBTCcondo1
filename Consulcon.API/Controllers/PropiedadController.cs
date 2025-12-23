using System.Threading.Tasks;
using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consulcon.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropiedadController : ControllerBase
    {
        private readonly IRepository<Propiedad> _repository;

        public PropiedadController(IRepository<Propiedad> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Will be automatically filtered by Global Query Filter in DbContext
            var data = await _repository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _repository.GetByIdAsync(id);
            if (data == null) return NotFound();
            return Ok(data);
        }
    }
}
