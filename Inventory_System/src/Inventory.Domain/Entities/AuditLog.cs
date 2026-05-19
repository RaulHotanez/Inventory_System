using Inventory.Domain.Common;

namespace Inventory.Domain.Entities
{
    public class AuditLog : AuditableEntity
    {
        public Guid UserId { get; set; }

        public User User { get; set; } = null!;

        public string Action { get; set; } = string.Empty;

        public string EntityName { get; set; } = string.Empty;

        public string EntityId { get; set; } = string.Empty;

        public string? OldValues { get; set; }

        public string? NewValues { get; set; }
    }
}
