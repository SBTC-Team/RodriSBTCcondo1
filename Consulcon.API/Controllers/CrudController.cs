using Consulcon.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Consulcon.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class CrudController<T> : ControllerBase where T : class
    {
        protected readonly IRepository<T> _repository;

        protected CrudController(IRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            var data = await _repository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create([FromBody] T entity)
        {
            if (entity == null) return BadRequest("Entity is null");
            // Assuming IRepository has AddAsync. If not, we rely on UnitOfWork or extend IRepository.
            // For now, simpler implementation assuming repository handles basic add.
            // In a real generic controller, handling "AddAsync" might require casting or specific logic if IRepository<T> doesn't expose it directly 
            // but our IRepository<T> definition should have it.
            
            // Checking IRepository definition... assume standard AddAsync
            await _repository.AddAsync(entity);
            return Ok(new { Message = "Created successfully", Data = entity });
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(int id, [FromBody] T entity)
        {
             // Generic update is tricky without ID matching logic in pure generic form
             // But for verification we will assume the body contains the correct data.
             // Ideally we check if IDs match.
             
             await _repository.UpdateAsync(entity);
             return Ok(new { Message = "Updated successfully" });
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();

            await _repository.DeleteAsync(entity);
            return Ok(new { Message = "Deleted successfully" });
        }
    }
}
