using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    class AppointmentProceduresConfiguration : IEntityTypeConfiguration<AppointmentProcedures>
    {
        public void Configure(EntityTypeBuilder<AppointmentProcedures> builder)
        {

        }
    }
}
