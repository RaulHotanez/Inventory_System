using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(Guid id);

        Task<IEnumerable<Product>> GetAllAsync();

        Task AddAsync(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
