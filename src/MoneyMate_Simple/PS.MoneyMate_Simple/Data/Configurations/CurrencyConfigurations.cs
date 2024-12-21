using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.MoneyMate_Simple.Entities;

namespace PS.MoneyMate_Simple.Data.Configurations
{
    public class CurrencyConfigurations : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            throw new NotImplementedException();
        }
    }
}
