using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(a => a.Id);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
