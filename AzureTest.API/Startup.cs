using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VetClinic.API.ExtensionMethods;
using VetClinic.API.Filters;
using VetClinic.API.Middlewares;
using VetClinic.BLL.Seeders;
using VetClinic.DAL;
using VetClinic.DAL.Repositories.Interfaces;
using VetClinic.DAL.Repositories.Realizations;

namespace AzureTest.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication("RefAndJWTToken")
                .AddIdentityServerAuthentication("RefAndJWTToken", options =>
                {
                    options.Authority = "https://localhost:5005";
                    options.ApiName = "VetClinicApi";
                    options.ApiSecret = "angular_secret";
                });


            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(connection, builder =>
                    builder.MigrationsAssembly("VetClinic.DAL")));

            services.AddIdentity();

            services.AddAutoMapper(typeof(Startup));

            services.AddControllers(options => { options.Filters.Add(new ValidationFilter()); })
                .AddFluentValidation(options => { options.RegisterValidatorsFromAssemblyContaining<Startup>(); })
                .AddNewtonsoftJson();

            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });

            services.AddSwaggerGen();

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddServices();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });

            services.AddSwaggerConfig();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                ApplicationDataSeeder.SeedData(app);
            }

            app.UseCors();

            app.UseMiddleware<ExceptionMiddleware>();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseCustomSwaggerConfig();

            ApplicationStaticDataSeeder.SeedStaticDataAsync(app);
        }
    }
}
