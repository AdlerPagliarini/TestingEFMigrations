using DatabaseModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseModel.Persistence.EntityConfigurations
{
    public class CarAccessoryNNConfiguration : IEntityTypeConfiguration<CarAccessoryNN>
    {
        public void Configure(EntityTypeBuilder<CarAccessoryNN> builder)
        {
            builder.HasKey(t => new { t.CarId, t.AccessoryId });
        }
    }
}
