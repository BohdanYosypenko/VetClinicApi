using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.FirstName).HasMaxLength(30);
            builder.Property(t => t.LastName).HasMaxLength(30);
            builder.Property(t => t.Email).HasMaxLength(50);
            builder.Property(t => t.NormalizedEmail).HasMaxLength(50);
            builder.Property(t => t.PasswordHash).HasMaxLength(300);
            builder.Property(t => t.PhoneNumber).HasMaxLength(12);
            builder.Property(t => t.UserName).HasMaxLength(50);
        }
    }
}
