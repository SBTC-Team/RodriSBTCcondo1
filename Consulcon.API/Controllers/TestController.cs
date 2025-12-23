using System.Threading.Tasks;
using Consulcon.Domain.Entities;
using Consulcon.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consulcon.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IRepository<Condominio> _condominioRepository;
        private readonly IRepository<Usuario> _usuarioRepository;

        public TestController(IRepository<Condominio> condominioRepository, IRepository<Usuario> usuarioRepository)
        {
            _condominioRepository = condominioRepository;
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("condominios")]
        public async Task<IActionResult> GetCondominios()
        {
            var data = await _condominioRepository.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("usuarios")]
        public async Task<IActionResult> GetUsuarios()
        {
            var data = await _usuarioRepository.GetAllAsync();
            return Ok(data);
        }
    }
}
