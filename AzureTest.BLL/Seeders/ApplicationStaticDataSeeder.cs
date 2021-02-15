using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Enums;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Seeders
{
    public static class ApplicationStaticDataSeeder
    {
        public static async Task SeedStaticDataAsync(IApplicationBuilder builder)
        {
            var services = new ServiceCollection();
            services.AddLogging();
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
                .CreateLogger();
            var provider = builder.ApplicationServices;
            var scopeFactory = provider.GetRequiredService<IServiceScopeFactory>();

            using (var scope = scopeFactory.CreateScope())
            {
                var repositoryWrapper = scope.ServiceProvider.GetService<IRepositoryWrapper>();
                var userManager = scope.ServiceProvider.GetService<UserManager<User>>();
                var roleMamager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                //admin

                var admin = new User { UserName = "admin", FirstName = "Admin", LastName = "Admin", Email = "Admin@email.com", PhoneNumber = "12345678910" };
                await MakeAdmin(admin, userManager);

                //accountant

                var accountant = new User { UserName = "accountant", FirstName = "Accountant", LastName = "Accountant", Email = "Accountant@email.com", PhoneNumber = "12345678910" };
                await MakeAccountant(accountant, userManager);

                //statuses

                List<Status> statuses = new List<Status>();
                statuses.Add(new Status { StatusName = StatusName.Approved });
                statuses.Add(new Status { StatusName = StatusName.Disapproved });
                statuses.Add(new Status { StatusName = StatusName.Processing });
                statuses.Add(new Status { StatusName = StatusName.Completed });

                await CreateStatuces(statuses, repositoryWrapper);
                await RemoveNotSeededStatuses(statuses, repositoryWrapper);

                //anymal types

                List<AnimalType> animalTypes = new List<AnimalType>();
                animalTypes.Add(new AnimalType { AnimalTypeName = "Dog" });
                animalTypes.Add(new AnimalType { AnimalTypeName = "Сat" });
                animalTypes.Add(new AnimalType { AnimalTypeName = "Rodent" });
                animalTypes.Add(new AnimalType { AnimalTypeName = "Bird" });
                animalTypes.Add(new AnimalType { AnimalTypeName = "Another" });

                await CreateAnymalTypes(animalTypes, repositoryWrapper);
                await RemoveNotSeededAnymalTypes(animalTypes, repositoryWrapper);

                //position

                List<Position> positions = new List<Position>();
                positions.Add(new Position { PositionName = "Сhief medical officer", Salary = 3000 });
                positions.Add(new Position { PositionName = "Head doctor", Salary = 2000 });
                positions.Add(new Position { PositionName = "Veterinarian", Salary = 1000 });
                positions.Add(new Position { PositionName = "Nurse", Salary = 500 });
                positions.Add(new Position { PositionName = "Fired", Salary = 0 });

                await CreatePositions(positions, repositoryWrapper);
                await RemoveNotSeededPosotins(positions, repositoryWrapper);

                //roles

                List<IdentityRole> roles = new List<IdentityRole>();
                roles.Add(new IdentityRole { Name = "client", NormalizedName = "CLIENT" });
                roles.Add(new IdentityRole { Name = "doctor", NormalizedName = "DOCTOR" });
                roles.Add(new IdentityRole { Name = "admin", NormalizedName = "ADMIN" });
                roles.Add(new IdentityRole { Name = "accountant", NormalizedName = "ACCOUNTANT" });

                await CreateRoles(roles, roleMamager);
                await RemoveNotSeededRoles(roles, roleMamager);
            }
        }

        private static async Task CreateStatuces(List<Status> statusesData, IRepositoryWrapper repositoryWrapper)
        {
            foreach (Status statusData in statusesData)
            {
                var status = await repositoryWrapper.StatusRepository.IsAnyAsync(s => s.StatusName == statusData.StatusName);
                if (!status)
                {
                    repositoryWrapper.StatusRepository.Add(statusData);
                    await repositoryWrapper.SaveAsync();
                    Log.Debug($@"{statusData.StatusName} created");
                }
                else
                {
                    Log.Debug($@"{statusData.StatusName} already exists");
                }
            }
        }

        private static async Task CreateAnymalTypes(List<AnimalType> animalTypesData, IRepositoryWrapper repositoryWrapper)
        {
            foreach (AnimalType animalTypeData in animalTypesData)
            {
                var animalType = await repositoryWrapper.AnimalTypeRepository.IsAnyAsync(s => s.AnimalTypeName == animalTypeData.AnimalTypeName);
                if (!animalType)
                {
                    repositoryWrapper.AnimalTypeRepository.Add(animalTypeData);
                    await repositoryWrapper.SaveAsync();
                    Log.Debug($@"{animalTypeData.AnimalTypeName} created");
                }
                else
                {
                    Log.Debug($@"{animalTypeData.AnimalTypeName} already exists");
                }
            }
        }

        private static async Task CreatePositions(List<Position> positionsData, IRepositoryWrapper repositoryWrapper)
        {
            foreach (Position positionData in positionsData)
            {
                var position = await repositoryWrapper.PositionRepository.IsAnyAsync(s => s.PositionName == positionData.PositionName &&
                s.Salary == positionData.Salary);
                if (!position)
                {
                    repositoryWrapper.PositionRepository.Add(positionData);
                    await repositoryWrapper.SaveAsync();
                    Log.Debug($@"{positionData.PositionName} created");
                }
                else
                {
                    Log.Debug($@"{positionData.PositionName} already exists");
                }
            }
        }

        private static async Task CreateRoles(List<IdentityRole> rolesData, RoleManager<IdentityRole> roleManager)
        {
            foreach (IdentityRole roleData in rolesData)
            {
                var role = await roleManager.FindByNameAsync(roleData.Name);
                if (role == null)
                {
                    await roleManager.CreateAsync(roleData);
                    Log.Debug($@"{roleData.Name} created");
                }
                else
                {
                    Log.Debug($@"{roleData.Name} already exists");
                }
            }
        }

        private static async Task RemoveNotSeededStatuses(List<Status> statusesData, IRepositoryWrapper repositoryWrapper)
        {
            var statuses = await repositoryWrapper.StatusRepository.GetAsync();
            foreach (Status statusData in statusesData)
            {
                Status status = await repositoryWrapper.StatusRepository.GetFirstOrDefaultAsync(filter: s => s.StatusName == statusData.StatusName);
                statuses.Remove(status);
            }

            foreach (Status removeStatus in statuses)
            {
                repositoryWrapper.StatusRepository.Remove(removeStatus);
            }

            await repositoryWrapper.SaveAsync();
        }

        private static async Task RemoveNotSeededAnymalTypes(List<AnimalType> anymalTypesData, IRepositoryWrapper repositoryWrapper)
        {
            var animalTypes = await repositoryWrapper.AnimalTypeRepository.GetAsync();
            foreach (AnimalType anymalTypeData in anymalTypesData)
            {
                AnimalType animalType = await repositoryWrapper.AnimalTypeRepository.GetFirstOrDefaultAsync(filter: s => s.AnimalTypeName == anymalTypeData.AnimalTypeName);
                animalTypes.Remove(animalType);
            }

            foreach (AnimalType removeAnimalType in animalTypes)
            {
                repositoryWrapper.AnimalTypeRepository.Remove(removeAnimalType);
            }

            await repositoryWrapper.SaveAsync();
        }

        private static async Task RemoveNotSeededPosotins(List<Position> positionsData, IRepositoryWrapper repositoryWrapper)
        {
            var positions = await repositoryWrapper.PositionRepository.GetAsync();
            foreach (Position positionData in positionsData)
            {
                Position position = await repositoryWrapper.PositionRepository.GetFirstOrDefaultAsync(filter: p => p.PositionName == positionData.PositionName &&
                p.Salary == positionData.Salary);
                positions.Remove(position);
            }

            foreach (Position removePosition in positions)
            {
                repositoryWrapper.PositionRepository.Remove(removePosition);
            }

            await repositoryWrapper.SaveAsync();
        }

        private static async Task RemoveNotSeededRoles(List<IdentityRole> rolesData, RoleManager<IdentityRole> roleMamager)
        {
            var notSeededroles = roleMamager.Roles.ToList();
            foreach (IdentityRole roleData in rolesData)
            {
                var role = await roleMamager.FindByNameAsync(roleData.Name);
                notSeededroles.Remove(role);
            }

            foreach (IdentityRole removeRole in notSeededroles)
            {
                await roleMamager.DeleteAsync(removeRole);
            }
        }

        private static async Task MakeAdmin(User userData, UserManager<User> userManager)
        {
            var user = await userManager.FindByNameAsync(userData.UserName);
            if (user == null)
            {
                user = userData;

                _ = await userManager.CreateAsync(user, "Pass123$");

                if (!await userManager.IsInRoleAsync(user, "admin"))
                {
                    _ = await userManager.AddToRoleAsync(user, "admin");
                }

                Log.Debug($@"{userData.UserName} created");
            }
            else
            {
                Log.Debug($@"{userData.UserName} already exists");
            }
        }

        private static async Task MakeAccountant(User userData, UserManager<User> userManager)
        {
            var user = await userManager.FindByNameAsync(userData.UserName);
            if (user == null)
            {
                user = userData;

                _ = await userManager.CreateAsync(user, "Pass123$");

                if (!await userManager.IsInRoleAsync(user, "accountant"))
                {
                    _ = await userManager.AddToRoleAsync(user, "accountant");
                }

                Log.Debug($@"{userData.UserName} created");
            }
            else
            {
                Log.Debug($@"{userData.UserName} already exists");
            }
        }
    }
}