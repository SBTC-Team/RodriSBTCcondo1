using Consulcon.Application.DTOs;
using Consulcon.Domain.Common;
using Consulcon.Application.Interfaces;
using Consulcon.Domain.Interfaces;
using Consulcon.Domain.Entities;

namespace Consulcon.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public AuthService(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Result<UserDto>> LoginAsync(string username, string password)
        {
            // 'usuario' column is mapped to 'UsuarioProperty'
            var users = await _usuarioRepository.FindAsync(u => u.UsuarioProperty == username);
            var user = users.FirstOrDefault();

            if (user == null)
                return Result.Fail<UserDto>("Usuario no encontrado");

            if (user.Contrasena != password)
                return Result.Fail<UserDto>("Contraseña incorrecta");

            // Map to DTO
            var dto = new UserDto
            {
                Id = user.PkUsuario,
                Username = user.UsuarioProperty,
                FullName = user.Nombrepersona,
                RoleId = user.FkTipousuario,
                Token = "dummy-token" // Tarea 5 doesn't explicitly demand real JWT yet, can add later
            };

            return Result.Ok(dto);
        }
    }
}
