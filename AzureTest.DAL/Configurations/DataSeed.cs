using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Enums;

namespace VetClinic.DAL.Configurations
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            Seed(builder.Entity<AnimalType>());
            Seed(builder.Entity<Position>());
            Seed(builder.Entity<IdentityRole>());
            Seed(builder.Entity<Status>());
        }

        private static void Seed(EntityTypeBuilder<AnimalType> builder)
        {
            builder.HasData(
               new AnimalType[]
               {
                    new AnimalType{ Id=1,AnimalTypeName="Dog"},
                    new AnimalType{ Id=2,AnimalTypeName="Сat"},
                    new AnimalType{ Id=3,AnimalTypeName="Rodent"},
                    new AnimalType{ Id=4,AnimalTypeName="Bird"},
                    new AnimalType{ Id=5,AnimalTypeName="Another"}
               });
        }

        private static void Seed(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole[]
                {
                    new IdentityRole{ Id = "542636ae-953e-4e04-a7de-7533f25af173", Name="client", NormalizedName = "CLIENT"},
                    new IdentityRole{ Id = "e65dd8e1-34f8-4e9d-b535-3b03dde2500e", Name="doctor", NormalizedName = "DOCTOR"},
                    new IdentityRole{ Id = "9149c77e-5c15-416a-9bed-e361330feb92", Name="admin", NormalizedName = "ADMIN"},
                    new IdentityRole{ Id = "ced370e3-1401-4190-9960-ab5bf41f162e", Name="accountant", NormalizedName = "ACCOUNTANT"},
                });
        }

        private static void Seed(EntityTypeBuilder<Position> builder)
        {
            builder.HasData(
                new Position[]
                {
                    new Position{ Id=1, PositionName="Сhief medical officer", Salary=3000},
                    new Position{ Id=2, PositionName="Head doctor", Salary=2000},
                    new Position{ Id=3, PositionName="Veterinarian", Salary=1000},
                    new Position{ Id=4, PositionName="Nurse", Salary=500},
                    new Position{ Id=5, PositionName="Fired", Salary=0}
                });
        }

        private static void Seed(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status[]
                {
                    new Status{ Id=1, StatusName=StatusName.Approved},
                    new Status{ Id=2, StatusName=StatusName.Disapproved},
                    new Status{ Id=3, StatusName=StatusName.Processing},
                    new Status{ Id=4, StatusName=StatusName.Completed},
                });
        }
    }
}