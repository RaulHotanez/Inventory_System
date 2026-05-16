using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities
{
    public class Warehouse : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public ICollection<InventoryMovement> InventoryMovements { get; set; }
            = new List<InventoryMovement>();
    }
}
