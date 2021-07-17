using eShopSolution.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Data.EF
{
    public class EShopDbContext : DbContext
    {
        private const string connextionStringSQL = "Server=DESKTOP-30RU26B\\SQLEXPRESS;database=EShop;user id=sa;password=123456;";
        public EShopDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactCofiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfigguration());
            modelBuilder.ApplyConfiguration(new OrderConfigguration());
            modelBuilder.ApplyConfiguration(new OrderditailConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfigguration());


            //base.OnModelCreating(modelBuilder);
        }

        #region Entites

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(connextionStringSQL);
        }
    }
}
