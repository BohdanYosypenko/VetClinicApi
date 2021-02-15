using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VetClinic.DAL.Configurations;
using VetClinic.DAL.Entities;

namespace VetClinic.DAL
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<AnimalType> AnimalTypes { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Procedure> Procedures { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual new DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

            DataSeeder.Seed(builder);
        }
    }
}