using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using System.Threading.Tasks;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Seeders
{
    public static class ApplicationUserSeeder
    {
        public static async Task SeedUsers(IApplicationBuilder builder)
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
                var userManager = scope.ServiceProvider.GetService<UserManager<User>>();
                var repositoryWrapper = scope.ServiceProvider.GetService<IRepositoryWrapper>();

                //admins
                var data = new User { UserName = "alice", FirstName = "Alice", LastName = "Smith", Email = "AliceSmith@email.com", PhoneNumber = "123456789123" };

                await MakeAdmin(data, userManager);

                //clients
                data = new User { Id = "111", FirstName = "Bob", LastName = "Smith", UserName = "bob", Email = "bob@gmail.com", PhoneNumber = "0481417644", PasswordHash = "Pass123$" };

                await MakeClient(data, new Client() { Id = 1 }, userManager, repositoryWrapper);

                data = new User { Id = "112", FirstName = "Andriy", LastName = "Vozniy", UserName = "VoAndr", Email = "VAndr@gmail.com", PhoneNumber = "0931412644", PasswordHash = "Pass123$" };

                await MakeClient(data, new Client() { Id = 2 }, userManager, repositoryWrapper);

                data = new User { Id = "113", FirstName = "Maruna", LastName = "Kosovich", UserName = "kosmar", Email = "KosovichMaruna@gmail.com", PhoneNumber = "0681236324", PasswordHash = "Pass123$" };

                await MakeClient(data, new Client() { Id = 3 }, userManager, repositoryWrapper);

                data = new User { Id = "114", FirstName = "Nadiya", LastName = "Mukolenko", UserName = "MukoNa", Email = "MukoNa@gmail.com", PhoneNumber = "0982931254", PasswordHash = "Pass123$" };

                await MakeClient(data, new Client() { Id = 4 }, userManager, repositoryWrapper);

                //doctors
                data = new User { Id = "72", FirstName = "Ma", LastName = "Guma", UserName = "magma", Email = "ma@gmail.com", PhoneNumber = "0939412644", PasswordHash = "Pass123$" };
                var doctorData = new Doctor { Id = 1, Education = "Gas and Oil", Experience = "2", PositionId = 1 };
                await MakeDoctor(data, doctorData, userManager, repositoryWrapper);

                data = new User { Id = "98", FirstName = "Gregory", LastName = "House", UserName = "house", Email = "house@gmail.com", PhoneNumber = "0939417534", PasswordHash = "Pass123$" };
                doctorData = new Doctor { Id = 2, Education = "America", Experience = "3", PositionId = 3 };
                await MakeDoctor(data, doctorData, userManager, repositoryWrapper);

                data = new User { Id = "64", FirstName = "Gomer", LastName = "Sipmson", UserName = "donut", Email = "donut@gmail.com", PhoneNumber = "0456412644", PasswordHash = "Pass123$" };
                doctorData = new Doctor { Id = 3, Education = "Nuke", Experience = "7", PositionId = 4 };
                await MakeDoctor(data, doctorData, userManager, repositoryWrapper);

                //accountants
                data = new User { Id = "80", FirstName = "Maryland", LastName = "Smith", UserName = "mary", Email = "mary_vetclinic@gmail.com", PhoneNumber = "0995412723", PasswordHash = "Pass123$" };
                await MakeAccountant(data, userManager);
            }
        }

        private static async Task MakeClient(User userData, Client clientData, UserManager<User> userManager, IRepositoryWrapper repositoryWrapper)
        {
            var user = userManager.FindByNameAsync(userData.UserName).Result;
            if (user == null)
            {
                user = userData;

                _ = await userManager.CreateAsync(user, "Pass123$");
                if (!await userManager.IsInRoleAsync(user, "client"))
                {
                    _ = await userManager.AddToRoleAsync(user, "client");
                }
                var client = await repositoryWrapper.ClientRepository.GetFirstOrDefaultAsync(filter: c => c.Id == clientData.Id);
                if (client != null)
                {
                    client.UserId = userData.Id;
                    repositoryWrapper.ClientRepository.Update(client);
                    Log.Debug($@"{userData.UserName} created");
                }
                else
                {
                    var newUser = await userManager.FindByNameAsync(userData.UserName);
                    Client newClient = new Client() { UserId = newUser.Id };
                    repositoryWrapper.ClientRepository.Add(newClient);
                }
                await repositoryWrapper.SaveAsync();
            }
            else
            {
                Log.Debug($@"{userData.UserName} already exists");
            }
        }

        private static async Task MakeDoctor(User userData, Doctor doctorData, UserManager<User> userManager, IRepositoryWrapper repositoryWrapper)
        {
            var user = await userManager.FindByNameAsync(userData.UserName);
            if (user == null)
            {
                user = userData;

                _ = await userManager.CreateAsync(user, "Pass123$");
                if (!await userManager.IsInRoleAsync(user, "doctor"))
                {
                    _ = await userManager.AddToRoleAsync(user, "doctor");
                }
                var doctor = await repositoryWrapper.DoctorRepository.GetFirstOrDefaultAsync(filter: d => d.Id == doctorData.Id);
                if (doctor != null)
                {
                    doctor.UserId = userData.Id;
                    repositoryWrapper.DoctorRepository.Update(doctor);
                    Log.Debug($@"{userData.UserName} created");
                }
                else
                {
                    var newUser = await userManager.FindByNameAsync(userData.UserName);
                    Doctor newDoctor = new Doctor()
                    {
                        UserId = newUser.Id,
                        Biography = doctorData.Biography,
                        Education = doctorData.Education,
                        Experience = doctorData.Experience,
                        PositionId = doctorData.PositionId,
                        Photo = doctorData.Photo
                    };
                    repositoryWrapper.DoctorRepository.Add(newDoctor);
                }
                await repositoryWrapper.SaveAsync();
            }
            else
            {
                Log.Debug($@"{userData.UserName} already exists");
            }
        }

        private static async Task MakeAdmin(User userData, UserManager<User> userManager)
        {
            var user = userManager.FindByNameAsync(userData.UserName).Result;
            if (user == null)
            {
                user = userData;

                _ = await userManager.CreateAsync(user, "Pass123$");

                if (!userManager.IsInRoleAsync(user, "admin").Result)
                {
                    _ = userManager.AddToRoleAsync(user, "admin").Result;
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
            var user = userManager.FindByNameAsync(userData.UserName).Result;
            if (user == null)
            {
                user = userData;

                _ = await userManager.CreateAsync(user, "Pass123$");

                if (!userManager.IsInRoleAsync(user, "accountant").Result)
                {
                    _ = userManager.AddToRoleAsync(user, "accountant").Result;
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