using System.Threading.Tasks;
using Consulcon.Application.DTOs;
using Consulcon.Domain.Common;

namespace Consulcon.Application.Interfaces
{
    public interface IAuthService
    {
        Task<Result<UserDto>> LoginAsync(string username, string password);
    }
}
