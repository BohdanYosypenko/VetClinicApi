using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Title).HasMaxLength(25);
            builder.Property(t => t.Subtitle).HasMaxLength(50);
            builder.Property(t => t.MainText).HasMaxLength(500);
            builder.Property(t => t.Photo).HasMaxLength(150);
        }
    }
}
