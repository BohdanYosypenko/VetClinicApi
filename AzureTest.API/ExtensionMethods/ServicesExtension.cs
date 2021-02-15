using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.BLL.Services.Realizations;
using VetClinic.DAL;
using VetClinic.DAL.Entities;

namespace VetClinic.API.ExtensionMethods
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProcedureService, ProcedureService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<IAnimalService, AnimalService>();
            services.AddScoped<IAnimalTypeService, AnimalTypeService>();
            services.AddScoped<IEmailNotificationService, EmailNotificationService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IFinancialReportService, FinancialReportService>();
        }

        public static void AddIdentity(this IServiceCollection services)
        {
            IdentityBuilder builder = services.AddIdentityCore<User>();
            builder = new IdentityBuilder(typeof(User), typeof(IdentityRole), builder.Services);
            builder.AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IRoleValidator<IdentityRole>, RoleValidator<IdentityRole>>();
            services.AddScoped<RoleManager<IdentityRole>, RoleManager<IdentityRole>>();
        }
    }
}