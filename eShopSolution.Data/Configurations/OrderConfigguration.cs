using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class OrderConfigguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderDate).IsRequired(true);
            builder.Property(x => x.ShipAddress).IsRequired(true);
            builder.Property(x => x.ShipName).IsRequired(true);
            builder.Property(x => x.ShipPhoneNumber).IsRequired(true);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(OrderStatus.Success);
        }
    }
}
