using Inventory.Domain.Common;

namespace Inventory.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
