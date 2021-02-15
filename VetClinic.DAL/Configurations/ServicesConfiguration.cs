using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    public class ServicesConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ServiceName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(2000).IsRequired();

            builder
                .HasMany(t => t.Appointments)
                .WithOne(t => t.Service)
                .HasForeignKey(t => t.ServiceId);
        }
    }
}
