using Inventory.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Infrastructure.Persistence.Configurations
{
    public class SalesOrderConfiguration : IEntityTypeConfiguration<SalesOrder>
    {
        public void Configure(EntityTypeBuilder<SalesOrder> builder)
        {
            builder.ToTable("SalesOrders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Total)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.Status)
                .IsRequired();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.SalesOrders)
                .HasForeignKey(x => x.CustomerId);

            builder.HasMany(x => x.Items)
                .WithOne(x => x.SalesOrder)
                .HasForeignKey(x => x.SalesOrderId);
        }
    }
}
