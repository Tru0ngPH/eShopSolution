using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslation");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.SeoAlias).IsRequired(true);
            builder.HasOne(x => x.Language).WithMany(x => x.CategoryTranslations)
                    .HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Category).WithMany(x => x.CategoryTranslations)
                    .HasForeignKey(x => x.CategoryId);
        }
    }
}
