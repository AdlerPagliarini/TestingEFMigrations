using DatabaseModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseModel.Persistence.EntityConfigurations
{
    public class PersonCarNNConfiguration : IEntityTypeConfiguration<PersonCarNN>
    {
        public void Configure(EntityTypeBuilder<PersonCarNN> builder)
        {
            builder.HasKey(t => new { t.PersonId, t.CarId });
        }
    }
}
