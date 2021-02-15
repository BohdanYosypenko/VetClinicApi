using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL.Configurations
{
    public class AppointmentsConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.Id);

            builder
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId);

            builder
                .HasOne(a => a.Animal)
                .WithMany(a => a.Appointments)
                .HasForeignKey(a => a.AnimalId);

            builder
                .HasOne(a => a.Status)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.StatusId);
            
            builder
                .HasOne(a => a.Service)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.ServiceId);
            
            builder
                .HasMany(a => a.AppointmentProcedures)
                .WithOne(a => a.Appointment)
                .HasForeignKey(a => a.AppointmentId);

            builder.Property(a => a.AppointmentDate).IsRequired();
            builder.Property(a => a.Complaints).IsRequired().HasMaxLength(100);
            builder.Property(a => a.TreatmentDescription).IsRequired(false).HasMaxLength(500);

            builder.Property(a => a.DoctorId).IsRequired(false);
            builder.Property(a => a.AnimalId).IsRequired();
            builder.Property(a => a.StatusId).IsRequired().HasDefaultValue(3);
            builder.Property(a => a.ServiceId).IsRequired();
        }
    }
}