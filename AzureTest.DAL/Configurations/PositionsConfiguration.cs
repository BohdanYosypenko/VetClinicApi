using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    public class PositionsConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Doctors)
                .WithOne(c => c.Position)
                .HasForeignKey(c => c.PositionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(t => t.PositionName).HasMaxLength(40);
        }
    }
}
