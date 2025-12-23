using System.Threading.Tasks;
using Consulcon.Domain.Interfaces;

namespace Consulcon.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ConsulconDbContext _context;

        public UnitOfWork(ConsulconDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
