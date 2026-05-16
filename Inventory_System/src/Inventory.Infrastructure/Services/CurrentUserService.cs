using System.Security.Claims;
using Inventory.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;

namespace Inventory.Infrastructure.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid UserId
    {
        get
        {
            var userId = _httpContextAccessor
                .HttpContext?
                .User?
                .FindFirstValue(ClaimTypes.NameIdentifier);

            return userId is null
                ? Guid.Empty
                : Guid.Parse(userId);
        }
    }
}