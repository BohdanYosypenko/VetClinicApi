using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    public class AnimalTypesConfiguration : IEntityTypeConfiguration<AnimalType>
    {
        public void Configure(EntityTypeBuilder<AnimalType> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.Animals)
                .WithOne(x => x.AnimalType)
                .HasForeignKey(x => x.AnimalTypeId);

            builder.Property(t => t.AnimalTypeName).HasMaxLength(30);
        }
    }
}
