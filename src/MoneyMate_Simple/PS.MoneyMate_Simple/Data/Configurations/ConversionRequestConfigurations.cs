using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.MoneyMate_Simple.Entities;

namespace PS.MoneyMate_Simple.Data.Configurations
{
    public class ConversionRequestConfigurations : IEntityTypeConfiguration<ConversionRequest>
    {
        public void Configure(EntityTypeBuilder<ConversionRequest> builder)
        {
            throw new NotImplementedException();
        }
    }
}
