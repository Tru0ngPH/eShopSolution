using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class ProductTranslationConfigguration : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("ProductTranslation");
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.SeoAlias).IsRequired(true);
            builder.HasOne(x => x.Language).WithMany(x => x.ProductTranslations)
                    .HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Product).WithMany(x => x.ProductTranslations)
                    .HasForeignKey(x => x.ProductId);
        }
    }
}
