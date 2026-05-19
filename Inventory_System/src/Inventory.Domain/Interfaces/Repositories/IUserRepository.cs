using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);

        Task<User?> GetByIdAsync(Guid id);

        Task AddAsync(User user);
    }
}
