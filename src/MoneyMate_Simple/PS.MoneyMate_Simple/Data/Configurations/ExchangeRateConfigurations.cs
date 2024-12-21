using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.MoneyMate_Simple.Entities;

namespace PS.MoneyMate_Simple.Data.Configurations
{
    public class ExchangeRateConfigurations : IEntityTypeConfiguration<ExchangeRate>
    {
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            throw new NotImplementedException();
        }
    }
}
