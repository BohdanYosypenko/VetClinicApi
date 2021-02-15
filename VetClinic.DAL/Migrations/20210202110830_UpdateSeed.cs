using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AppointmentProcedures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Animals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AnimalTypeName",
                value: "Dog");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AnimalTypeName",
                value: "Сat");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AnimalTypeName",
                value: "Rodent");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "AnimalTypeName",
                value: "Bird");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "AnimalTypeName",
                value: "Another");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "72ea3b3d-dbd2-410d-9f09-cb0a15b9a5fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "d8e03449-9bf3-4fa0-a1de-8d6921e452bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "79672f52-7750-474c-b664-33e7a593940e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "fe150231-ee21-4a41-ac28-e8eb066c8c33");

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PositionName", "Salary" },
                values: new object[] { "Сhief medical officer", 3000m });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PositionName", "Salary" },
                values: new object[] { "Head doctor", 2000m });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Salary",
                value: 1000m);

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PositionName", "Salary" },
                values: new object[] { "Nurse", 500m });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "PositionName", "Salary" },
                values: new object[] { 5, "Fired", 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Animals");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AnimalTypeName",
                value: "Pes dvorovuy");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AnimalTypeName",
                value: "Kit Domashniy");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AnimalTypeName",
                value: "Slon");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "AnimalTypeName",
                value: "Zhuraph");

            migrationBuilder.UpdateData(
                table: "AnimalTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "AnimalTypeName",
                value: "Zolota Rubka");

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "Id", "AnimalTypeName" },
                values: new object[,]
                {
                    { 6, "Homyak" },
                    { 7, "Monster" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "daf4c74a-6978-42d8-8583-073e937ab568");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "3b041468-a503-44ee-b977-5028590c28f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "bde816ed-fa5d-4bb4-887b-7ac08f8bd0ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "b7d356de-1a1f-40b8-bea1-0c79af512823");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, "07b04ba6-566f-49b9-97c0-92ad28997987", "KosovichMaruna@gmail.com", false, "Maruna", "Kosovich", false, null, null, null, null, "0681236324", false, "007433ed-9903-4b34-9573-51e00a866d62", false, "Kosovich Maruna" },
                    { "7", 0, "72cc948d-9e95-49e8-b63d-38f0062e391d", "MukolenkoNadiya@gmail.com", false, "Nadiya", "Mukolenko", false, null, null, null, null, "0982131254", false, "a183a647-2492-4a90-8add-9bdb29c48a20", false, "Mukolenko Nadiya" },
                    { "6", 0, "f8e14719-9c64-442a-9ed9-dc7163712cbc", "WernudubIvan@gmail.com", false, "Ivan", "Wernudub", false, null, null, null, null, "0982123654", false, "e27a6a96-6199-4938-b66e-211bc2e3aa10", false, "Wernudub Ivan" },
                    { "4", 0, "48327729-c171-4a8b-89b0-5fe0ad9114f5", "VozniyAndriy@gmail.com", false, "Andriy", "Vozniy", false, null, null, null, null, "0931412622", false, "0a782e75-d812-48fe-a1d7-6224edbe01e7", false, "Vozniy Andriy" },
                    { "3", 0, "4f4cef11-e6e3-4065-8adf-9f68da20d90f", "NoorkovaShuba@gmail.com", false, "Shuba", "Noorkova", false, null, null, null, null, "0934453214", false, "f75eff4e-63f7-4df7-90eb-758e2f85e189", false, "Noorkova Shuba" },
                    { "1", 0, "413ca0a0-b960-4e2b-a719-cce4b68d1ead", "KolesoAnastasiya@gmail.com", false, "Anastasiya", "Koleso", false, null, null, null, null, "0984112333", false, "c3cc1978-c181-44cb-946d-7ca1dace3ae0", false, "Koleso Anastasiya" },
                    { "2", 0, "0fa64668-d1db-431c-a6a2-13ce8fbb6a22", "NazarenkoOleh@gmail.com", false, "Oleh", "Nazarenko", false, null, null, null, null, "0954453374", false, "f5f784bf-9b40-46d2-9c3a-905171150ca7", false, "Nazarenko Oleh" }
                });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PositionName", "Salary" },
                values: new object[] { "Вirector", 100000m });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PositionName", "Salary" },
                values: new object[] { "Сleaner", 10000m });

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Salary",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PositionName", "Salary" },
                values: new object[] { "Stylist", 1000m });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "Id", "Description", "Price", "ProcedureName" },
                values: new object[,]
                {
                    { 1, "Best for your pet", 1000m, "SPA procedure" },
                    { 2, "Paw fracture", 2000m, "Operation" },
                    { 3, "Pet inspection", 50m, "Examination of animal" },
                    { 4, "Bad operation", 240m, "Сastration" },
                    { 5, "Doctor Consultation about care and maintenance of the animal", 100m, "Consultation" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "ServiceName" },
                values: new object[,]
                {
                    { 7, "Cardiology services are provided by Grant Petrie. In addition to an extensive medical history review, a consultation may include echocardiography, electrocardiography, radiography, blood pressure monitoring and 24 hour Holter monitoring to evaluate the cardiac status of your pet.", "Cardiology" },
                    { 10, "Among the most useful tools we use to evaluate a pet’s condition is diagnostic imaging. This includes radiographs (x-rays) and ultrasonography (ultrasound) both of which are carried out at York Street. We are able to refer pets for other forms of imaging if needed, this may include computed tomography (CT scans) and magnetic resonance imaging (MRI scans). Each of these provides different kinds of images, and in some instances more than one may be suggested by us to evaluate a particular problem in your pet. All of these methods provide ‘pictures’ of internal structures.", "Diagnostic Imaging" },
                    { 5, "Internal medicine services cover hormonal, gastrointestinal, urinary, haematologic (blood related), respiratory, infectious, and immune-mediated diseases. The facilities at the London Veterinary Clinic are co-ordinated by Grant Petrie. In addition to an extensive review of your pet’s medical history, diagnostics always begin with a thorough physical examination and blood tests. When more information is needed, ultrasound, radiography, endoscopy, and CT imaging may be used. Our objective is to make an accurate diagnosis as rapidly as possible while at the same time putting your pet (and you) to a minimum of inconvenience.", "Internal Medicine" },
                    { 4, "The anaesthetics and drugs we use during surgery together with the methods we use to monitor vital signs are comparable to those used for us when we have hospital operations. Continuous monitoring includes blood pressure, electrocardiogram, oxygen saturation, carbon dioxide levels, and ventilation. With the skill of our staff, it is ‘normal’ for us to successfully operate on very old, very sick animals that have a multitude of medical problems. While we never take the administration of a general anaesthetic casually, anaesthetic complications are rare despite the sometimes severe nature of the problems we manage.", "Surgery" },
                    { 3, @"During regular hospital hours, vet clinic can provide urgent care assistance. We will partner with you to determine whether referral to a specialty or emergency hospital is in your pet’s best interest. Depending on your pet’s individual needs and hospital capacity, assistance may consist of: 
                                                                                Urgent care stabilization;
                                                                                Referrals to specialty or emergency hospitals;
                                                                                Laboratory testing and x-rays;
                                                                                IV fluid therapy, pain control, infection treatments;
                                                                                Wound and fracture care;
                                                                                Treatment for poisonings or seizures", "Urgently" },
                    { 2, "We vaccinate and give booster inoculations according to an individual’s life style. We can do antibody titre tests to see if a dog actually needs a booster inoculation but rather than use in house antibody tests (that can produce false negatives), we use the gold standard and send all blood samples to the DEFRA approved specialist diagnostic laboratory used for rabies antibody titre analysis.", "Vacination" },
                    { 8, "We will take a full medical history and may take an ear or skin swab or skin scrapings to help with the diagnosis. In rare and unusual skin conditions a skin biopsy may be needed. For allergic skin conditions exclusion diets are often recommended and allergy testing for inhaled allergies (pollens, moulds, dust mites etc) is done on blood samples sent to a specialist laboratory in The Netherlands. We have specialist referral veterinary dermatologist available for the most challenging cases.", "Dermatology" },
                    { 9, "Your pet's oral health is a good indicator of their overall health. Your pet's teeth should be checked at least once a year for early signs of problems. Our hospitals offer anesthetized dental cleanings and procedures.", "Dental Care" },
                    { 1, "Basic medical examination of your animal by a fully equipped modern operating theatre and a pharmacy room. Our dental units provide facilities for all normal veterinary procedures. Diagnostic and surgical facilities include x-ray, ultrasound, electrocardiography, Doppler blood pressure, and a range of diagnostic endoscopes.", "Inspection" },
                    { 6, "We focus on preventive veterinary care to promote and improve overall pet health. Routine check-ups allow us to diagnose, treat and protect your pet from contracting serious, costly and sometimes fatal diseases. Offering a holistic approach to pet health, we partner with our clients to make sure their pets receive proper preventive", "Preventive Care" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "4" },
                    { 2, "5" },
                    { 3, "6" },
                    { 4, "7" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "Education", "Experience", "Photo", "PositionId", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Gas and Oil", "2", null, 1, "1" },
                    { 2, null, "IfMedical", "7", null, 3, "2" },
                    { 3, null, "SelfEducation", "3", null, 4, "3" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalTypeId", "ClientId", "Name", "Photo" },
                values: new object[,]
                {
                    { 2, 3, 2, 1, "Ruzhuk", null },
                    { 6, 1, 6, 1, "Krug", null },
                    { 8, 2, 2, 1, "Robin", null },
                    { 3, 5, 1, 2, "Sirko", null },
                    { 1, 342, 7, 3, "Pushok", null },
                    { 7, 1, 5, 3, "Dzvin", null },
                    { 4, 12, 3, 4, "Biznes", null },
                    { 5, 4, 4, 4, "Hmarochos", null }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AnimalId", "AppointmentDate", "Complaints", "DoctorId", "ServiceId", "StatusId", "TreatmentDescription" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2020, 4, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), "Bad wool", 3, 2, 3, "Use animal shampoo" },
                    { 6, 6, new DateTime(2019, 2, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), "Vaccination", 2, 1, 3, "" },
                    { 8, 8, new DateTime(2020, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), "Paw fracture", 2, 3, 1, "daily bandage change" },
                    { 3, 3, new DateTime(2020, 1, 12, 10, 30, 0, 0, DateTimeKind.Unspecified), "Required castration", 2, 4, 4, "wear a collar for 12 days" },
                    { 1, 1, new DateTime(2020, 5, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), "Temperature", 1, 1, 2, "Drink more wather" },
                    { 7, 7, new DateTime(2020, 12, 12, 12, 30, 0, 0, DateTimeKind.Unspecified), "Sore spine", 2, 1, 2, "daily walk" },
                    { 4, 4, new DateTime(2019, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), "Spa procedure", 3, 2, 1, "Spa every weak" },
                    { 5, 5, new DateTime(2019, 11, 15, 12, 30, 0, 0, DateTimeKind.Unspecified), "Need consultation", 3, 1, 4, "Pay more attention" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentProcedures",
                columns: new[] { "Id", "AppointmentId", "ProcedureId" },
                values: new object[,]
                {
                    { 2, 2, 2 },
                    { 6, 6, 3 },
                    { 9, 8, 4 },
                    { 3, 3, 3 },
                    { 1, 1, 1 },
                    { 10, 1, 3 },
                    { 7, 7, 5 },
                    { 8, 7, 4 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });
        }
    }
}
