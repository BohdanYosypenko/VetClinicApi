using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    public class DoctorsConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(d => d.User)
                .WithOne(d => d.Doctor);

            builder.HasMany(d => d.Appointments)
                .WithOne(d => d.Doctor)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Position)
                .WithMany(c => c.Doctors)
                .HasForeignKey(c => c.PositionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.Education).HasMaxLength(100);
            builder.Property(t => t.Experience).HasMaxLength(200);
        }
    }
}
