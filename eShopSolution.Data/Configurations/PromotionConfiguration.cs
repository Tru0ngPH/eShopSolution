using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.ToDate).IsRequired(true);
            builder.Property(x => x.FromDate).IsRequired(true);
            builder.Property(x => x.DiscountPercent).IsRequired(true);
        }
    }
}
