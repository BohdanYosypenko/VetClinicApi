using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Seeders
{
    public static class ApplicationDataSeeder
    {
        public static async Task SeedData(IApplicationBuilder builder)
        {
            var provider = builder.ApplicationServices;
            var scopeFactory = provider.GetRequiredService<IServiceScopeFactory>();

            using (var scope = scopeFactory.CreateScope())
            {
                var repositoryWrapper = scope.ServiceProvider.GetService<IRepositoryWrapper>();

                await ApplicationUserSeeder.SeedUsers(builder);
                await CreateServices(repositoryWrapper);
                await CreateProcedures(repositoryWrapper);
                await CreateAnymals(repositoryWrapper);
                await CreateAppointments(repositoryWrapper);
                await CreateAppointmentProcedures(repositoryWrapper);

            }

        }
        private static async Task CreateAnymals(IRepositoryWrapper repositoryWrapper)
        {
            if ((await repositoryWrapper.AnimalRepository.GetAsync()).Count == 0)
            {
                Animal[] animals = new Animal[]
                 {
                   new Animal{ Name="Pushok", Age=342, ClientId=7,AnimalTypeId=3},
                   new Animal{ Name="Ruzhuk", Age=3, ClientId=5,AnimalTypeId=2},
                   new Animal{ Name="Sirko", Age=5, ClientId=6,AnimalTypeId=1},
                   new Animal{ Name="Biznes", Age=12, ClientId=8,AnimalTypeId=3},
                   new Animal{ Name="Hmarochos", Age=4, ClientId=8,AnimalTypeId=4},
                   new Animal{ Name="Krug", Age=1, ClientId=5,AnimalTypeId=1},
                   new Animal{ Name="Dzvin", Age=1, ClientId=7,AnimalTypeId=5},
                   new Animal{ Name="Robin", Age=2, ClientId=6,AnimalTypeId=2}
                 };

                foreach (Animal animalData in animals)
                {
                    repositoryWrapper.AnimalRepository.Add(animalData);
                }
                await repositoryWrapper.SaveAsync();
            }
        }

        private static async Task CreateProcedures(IRepositoryWrapper repositoryWrapper)
        {
            if ((await repositoryWrapper.ProcedureRepository.GetAsync()).Count == 0)
            {
                var procedures = new Procedure[]
                {
                    new Procedure{ ProcedureName="SPA procedure", Description="Best for your pet", Price=1000},
                    new Procedure{ ProcedureName="Operation", Description="Paw fracture", Price=2000},
                    new Procedure{ ProcedureName="Examination of animal", Description="Pet inspection", Price=50},
                    new Procedure{ ProcedureName="Сastration", Description="Bad operation", Price=240},
                    new Procedure{ ProcedureName="Consultation", Description="Doctor Consultation about care and maintenance of the animal", Price=100},
                };

                foreach (Procedure procedureData in procedures)
                {
                    repositoryWrapper.ProcedureRepository.Add(procedureData);
                }
                await repositoryWrapper.SaveAsync();
            }
        }

        private static async Task CreateServices(IRepositoryWrapper repositoryWrapper)
        {
            if ((await repositoryWrapper.ServiceRepository.GetAsync()).Count == 0)
            {
                var services = new Service[]
                {
                    new Service{ ServiceName="Inspection", Description=@"Basic medical examination of your animal by a fully equipped modern operating theatre and a pharmacy room. Our dental units provide facilities for all normal veterinary procedures. Diagnostic and surgical facilities include x-ray, ultrasound, electrocardiography, Doppler blood pressure, and a range of diagnostic endoscopes."},
                    new Service{ ServiceName="Vacination", Description=@"We vaccinate and give booster inoculations according to an individual’s life style. We can do antibody titre tests to see if a dog actually needs a booster inoculation but rather than use in house antibody tests (that can produce false negatives), we use the gold standard and send all blood samples to the DEFRA approved specialist diagnostic laboratory used for rabies antibody titre analysis."},
                    new Service{ ServiceName="Urgently", Description= @"During regular hospital hours, vet clinic can provide urgent care assistance. We will partner with you to determine whether referral to a specialty or emergency hospital is in your pet’s best interest. Depending on your pet’s individual needs and hospital capacity, assistance may consist of: 
                                                                Urgent care stabilization;
                                                                Referrals to specialty or emergency hospitals;
                                                                Laboratory testing and x-rays;
                                                                IV fluid therapy, pain control, infection treatments;
                                                                Wound and fracture care;
                                                                Treatment for poisonings or seizures"},
                    new Service{ ServiceName="Surgery", Description= @"The anaesthetics and drugs we use during surgery together with the methods we use to monitor vital signs are comparable to those used for us when we have hospital operations. Continuous monitoring includes blood pressure, electrocardiogram, oxygen saturation, carbon dioxide levels, and ventilation. With the skill of our staff, it is ‘normal’ for us to successfully operate on very old, very sick animals that have a multitude of medical problems. While we never take the administration of a general anaesthetic casually, anaesthetic complications are rare despite the sometimes severe nature of the problems we manage."},
                    new Service{ ServiceName="Internal Medicine", Description=@"Internal medicine services cover hormonal, gastrointestinal, urinary, haematologic (blood related), respiratory, infectious, and immune-mediated diseases. The facilities at the London Veterinary Clinic are co-ordinated by Grant Petrie. In addition to an extensive review of your pet’s medical history, diagnostics always begin with a thorough physical examination and blood tests. When more information is needed, ultrasound, radiography, endoscopy, and CT imaging may be used. Our objective is to make an accurate diagnosis as rapidly as possible while at the same time putting your pet (and you) to a minimum of inconvenience."},
                    new Service{ ServiceName="Preventive Care", Description=@"We focus on preventive veterinary care to promote and improve overall pet health. Routine check-ups allow us to diagnose, treat and protect your pet from contracting serious, costly and sometimes fatal diseases. Offering a holistic approach to pet health, we partner with our clients to make sure their pets receive proper preventive"},
                    new Service{ ServiceName="Cardiology", Description=@"Cardiology services are provided by Grant Petrie. In addition to an extensive medical history review, a consultation may include echocardiography, electrocardiography, radiography, blood pressure monitoring and 24 hour Holter monitoring to evaluate the cardiac status of your pet."},
                    new Service{ ServiceName="Dermatology", Description=@"We will take a full medical history and may take an ear or skin swab or skin scrapings to help with the diagnosis. In rare and unusual skin conditions a skin biopsy may be needed. For allergic skin conditions exclusion diets are often recommended and allergy testing for inhaled allergies (pollens, moulds, dust mites etc) is done on blood samples sent to a specialist laboratory in The Netherlands. We have specialist referral veterinary dermatologist available for the most challenging cases."},
                    new Service{ ServiceName="Dental Care", Description=@"Your pet's oral health is a good indicator of their overall health. Your pet's teeth should be checked at least once a year for early signs of problems. Our hospitals offer anesthetized dental cleanings and procedures."},
                    new Service{ ServiceName="Diagnostic Imaging", Description=@"Among the most useful tools we use to evaluate a pet’s condition is diagnostic imaging. This includes radiographs (x-rays) and ultrasonography (ultrasound) both of which are carried out at York Street. We are able to refer pets for other forms of imaging if needed, this may include computed tomography (CT scans) and magnetic resonance imaging (MRI scans). Each of these provides different kinds of images, and in some instances more than one may be suggested by us to evaluate a particular problem in your pet. All of these methods provide ‘pictures’ of internal structures."}
                };

                foreach (Service serviceData in services)
                {
                    repositoryWrapper.ServiceRepository.Add(serviceData);
                }
                await repositoryWrapper.SaveAsync();
            }
        }

        private static async Task CreateAppointmentProcedures(IRepositoryWrapper repositoryWrapper)
        {
            if ((await repositoryWrapper.AppointmentProceduresRepository.GetAsync()).Count == 0)
            {
                var appointmentProcedures = new AppointmentProcedures[]
                  {
                    new AppointmentProcedures{ AppointmentId=9, ProcedureId=6},
                    new AppointmentProcedures{ AppointmentId=10, ProcedureId=7},
                    new AppointmentProcedures{ AppointmentId=11, ProcedureId=8},
                    new AppointmentProcedures{ AppointmentId=12, ProcedureId=9},
                    new AppointmentProcedures{ AppointmentId=13, ProcedureId=10},
                    new AppointmentProcedures{ AppointmentId=14, ProcedureId=10},
                    new AppointmentProcedures{ AppointmentId=15, ProcedureId=9},
                    new AppointmentProcedures{ AppointmentId=15, ProcedureId=6},
                    new AppointmentProcedures{ AppointmentId=16, ProcedureId=7},
                    new AppointmentProcedures{ AppointmentId=11, ProcedureId=8}
                  };

                foreach (AppointmentProcedures appointmentProcedureData in appointmentProcedures)
                {
                    repositoryWrapper.AppointmentProceduresRepository.Add(appointmentProcedureData);
                }
                await repositoryWrapper.SaveAsync();
            }
        }

        private static async Task CreateAppointments(IRepositoryWrapper repositoryWrapper)
        {
            if ((await repositoryWrapper.AppointmentRepository.GetAsync()).Count == 0)
            {

                repositoryWrapper.AppointmentRepository.Add(new Appointment
                {
                    AnimalId = 14,
                    AppointmentDate = new DateTime(2020, 5, 1, 8, 30, 0),
                    Complaints = "Temperature",
                    TreatmentDescription = "Drink more wather",
                    DoctorId = 4,
                    ServiceId = 11,
                    StatusId = 2
                });

                repositoryWrapper.AppointmentRepository.Add(new Appointment
                {
                    AnimalId = 10,
                    AppointmentDate = new DateTime(2020, 4, 23, 9, 30, 0),
                    Complaints = "Bad wool",
                    TreatmentDescription = "Use animal shampoo",
                    DoctorId = 6,
                    ServiceId = 12,
                    StatusId = 3
                });

                repositoryWrapper.AppointmentRepository.Add(new Appointment
                {
                    AnimalId = 11,
                    AppointmentDate = new DateTime(2020, 1, 12, 10, 30, 0),
                    Complaints = "Required castration",
                    TreatmentDescription = "wear a collar for 12 days",
                    DoctorId = 5,
                    ServiceId = 14,
                    StatusId = 4
                });

                repositoryWrapper.AppointmentRepository.Add(new Appointment
                {
                    AnimalId = 12,
                    AppointmentDate = new DateTime(2019, 5, 14, 11, 30, 0),
                    Complaints = "Spa procedure",
                    TreatmentDescription = "Spa every weak",
                    DoctorId = 6,
                    ServiceId = 12,
                    StatusId = 1
                });

                repositoryWrapper.AppointmentRepository.Add(new Appointment
                {
                    AnimalId = 13,
                    AppointmentDate = new DateTime(2019, 11, 15, 12, 30, 0),
                    Complaints = "Need consultation",
                    TreatmentDescription = "Pay more attention",
                    DoctorId = 6,
                    ServiceId = 11,
                    StatusId = 4
                });

                repositoryWrapper.AppointmentRepository.Add(new Appointment
                {
                    AnimalId = 14,
                    AppointmentDate = new DateTime(2019, 2, 2, 9, 30, 0),
                    Complaints = "Vaccination",
                    TreatmentDescription = "",
                    DoctorId = 5,
                    ServiceId = 11,
                    StatusId = 3
                });

                repositoryWrapper.AppointmentRepository.Add(new Appointment
                {
                    AnimalId = 15,
                    AppointmentDate = new DateTime(2020, 12, 12, 12, 30, 0),
                    Complaints = "Sore spine",
                    TreatmentDescription = "daily walk",
                    DoctorId = 5,
                    ServiceId = 11,
                    StatusId = 2
                });

                repositoryWrapper.AppointmentRepository.Add(new Appointment
                {
                    AnimalId = 16,
                    AppointmentDate = new DateTime(2020, 3, 30, 10, 30, 0),
                    Complaints = "Paw fracture",
                    TreatmentDescription = "daily bandage change",
                    DoctorId = 5,
                    ServiceId = 13,
                    StatusId = 1
                });

                await repositoryWrapper.SaveAsync();
            }
        }
    }
}