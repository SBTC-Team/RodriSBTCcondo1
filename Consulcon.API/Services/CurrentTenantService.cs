using System.Linq;
using Microsoft.AspNetCore.Http;
using Consulcon.Domain.Interfaces;

namespace Consulcon.API.Services
{
    public class CurrentTenantService : ICurrentTenantService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentTenantService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string TenantId
        {
            get
            {
                var context = _httpContextAccessor.HttpContext;
                if (context != null && context.Request.Headers.TryGetValue("X-Tenant-Id", out var tenantId))
                {
                    return tenantId;
                }
                return null;
            }
        }
    }
}
