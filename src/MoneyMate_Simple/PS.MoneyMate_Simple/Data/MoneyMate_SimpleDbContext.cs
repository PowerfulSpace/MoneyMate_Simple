using Microsoft.EntityFrameworkCore;
using PS.MoneyMate_Simple.Entities;

namespace PS.MoneyMate_Simple.Data
{
    public class MoneyMate_SimpleDbContext : DbContext
    {
        public MoneyMate_SimpleDbContext(DbContextOptions<MoneyMate_SimpleDbContext> options) : base(options)
        {
        }

        public DbSet<Currency> Currencies { get; set; } = null!;
        public DbSet<ConversionRequest> ConversionRequests { get; set; } = null!;
        public DbSet<ExchangeRate> ExchangeRates { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(MoneyMate_SimpleDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
