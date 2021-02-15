using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Enums;

namespace VetClinic.DAL.Configurations
{
    public class StatusesConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.Property(t => t.StatusName)
                .HasConversion(new EnumToStringConverter<StatusName>())
                .HasMaxLength(20);
        }
    }
}
