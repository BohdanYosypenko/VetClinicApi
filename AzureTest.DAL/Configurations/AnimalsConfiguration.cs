using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    public class AnimalsConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.AnimalType)
                .WithMany(x => x.Animals)
                .HasForeignKey(x => x.AnimalTypeId);

            builder
                .HasOne(x => x.Client)
                .WithMany(x => x.Animals)
                .HasForeignKey(x => x.ClientId);
            builder
                .HasMany(x => x.Appointments)
                .WithOne(x => x.Animal)
                .HasForeignKey(x => x.AnimalId);

            builder.Property(t => t.Name).HasMaxLength(20);
            builder.Property(t => t.Photo).HasMaxLength(150);
        }
    }
}
