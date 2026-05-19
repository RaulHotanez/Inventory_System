using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category?> GetByIdAsync(Guid id);

        Task<IEnumerable<Category>> GetAllAsync();

        Task AddAsync(Category category);

        void Update(Category category);

        void Delete(Category category);
    }
}
