using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces.Services
{
    public interface IJwtService
    {
        string GenerateToken(Guid userId, string email, string role);
    }
}
