using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class ContactCofiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.PhoneNumber).IsRequired(true);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
