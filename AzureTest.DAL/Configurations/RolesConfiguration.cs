using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VetClinic.DAL.Configurations
{
    public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(32);
            builder.Property(t => t.NormalizedName).HasMaxLength(32);
        }
    }
}