using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class AddDescriptionForServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "eca63292-6928-40e1-b471-e587bc381da4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "7db7268b-8d3f-4ce0-8a09-b939d7d0da9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "5ad852b4-bc13-4266-92d4-7a3fbb2ebb33");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "a2061557-655e-4b18-ac47-b67486f2c2ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b4e55bb8-2cff-4aef-ac57-e3df274bdefe", "2c90dc7c-f301-4ed9-9cdc-a187c2b9617f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63732b37-2439-4c01-b6b6-a6d749f59d80", "f7559400-6b09-41e2-b4ee-4cd52d727c62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10512230-b103-4589-b27d-07196ffe8556", "65d59a96-2915-4269-9dbc-e0f650a329ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6efcf126-91e5-45ae-8ce0-94a5d823184d", "f4a69ca1-554e-436f-93ab-372ee30f050f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c4efa61-c854-47a7-ac77-fd8cce4425dc", "d8f39b70-7e77-4f01-9ab0-5e8d7d00d7ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0934fbf-cd35-472e-a87a-2855828aa8fc", "bde4ed69-c2be-4dde-b9f8-afd9a8c27b8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dddc7448-2d72-4436-8306-5fcba201abab", "285ebd92-63cd-4c71-8bf1-d0d34e3a8e91" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Basic medical examination of your animal by a fully equipped modern operating theatre and a pharmacy room. Our dental units provide facilities for all normal veterinary procedures. Diagnostic and surgical facilities include x-ray, ultrasound, electrocardiography, Doppler blood pressure, and a range of diagnostic endoscopes.");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "We vaccinate and give booster inoculations according to an individual’s life style. We can do antibody titre tests to see if a dog actually needs a booster inoculation but rather than use in house antibody tests (that can produce false negatives), we use the gold standard and send all blood samples to the DEFRA approved specialist diagnostic laboratory used for rabies antibody titre analysis.", "Vacination" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: @"During regular hospital hours, vet clinic can provide urgent care assistance. We will partner with you to determine whether referral to a specialty or emergency hospital is in your pet’s best interest. Depending on your pet’s individual needs and hospital capacity, assistance may consist of: 
                                                                Urgent care stabilization;
                                                                Referrals to specialty or emergency hospitals;
                                                                Laboratory testing and x-rays;
                                                                IV fluid therapy, pain control, infection treatments;
                                                                Wound and fracture care;
                                                                Treatment for poisonings or seizures");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ServiceName" },
                values: new object[] { "The anaesthetics and drugs we use during surgery together with the methods we use to monitor vital signs are comparable to those used for us when we have hospital operations. Continuous monitoring includes blood pressure, electrocardiogram, oxygen saturation, carbon dioxide levels, and ventilation. With the skill of our staff, it is ‘normal’ for us to successfully operate on very old, very sick animals that have a multitude of medical problems. While we never take the administration of a general anaesthetic casually, anaesthetic complications are rare despite the sometimes severe nature of the problems we manage.", "Surgery" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "ServiceName" },
                values: new object[,]
                {
                    { 10, "Among the most useful tools we use to evaluate a pet’s condition is diagnostic imaging. This includes radiographs (x-rays) and ultrasonography (ultrasound) both of which are carried out at York Street. We are able to refer pets for other forms of imaging if needed, this may include computed tomography (CT scans) and magnetic resonance imaging (MRI scans). Each of these provides different kinds of images, and in some instances more than one may be suggested by us to evaluate a particular problem in your pet. All of these methods provide ‘pictures’ of internal structures.", "Diagnostic Imaging" },
                    { 9, "Your pet's oral health is a good indicator of their overall health. Your pet's teeth should be checked at least once a year for early signs of problems. Our hospitals offer anesthetized dental cleanings and procedures.", "Dental Care" },
                    { 8, "We will take a full medical history and may take an ear or skin swab or skin scrapings to help with the diagnosis. In rare and unusual skin conditions a skin biopsy may be needed. For allergic skin conditions exclusion diets are often recommended and allergy testing for inhaled allergies (pollens, moulds, dust mites etc) is done on blood samples sent to a specialist laboratory in The Netherlands. We have specialist referral veterinary dermatologist available for the most challenging cases.", "Dermatology" },
                    { 7, "Cardiology services are provided by Grant Petrie. In addition to an extensive medical history review, a consultation may include echocardiography, electrocardiography, radiography, blood pressure monitoring and 24 hour Holter monitoring to evaluate the cardiac status of your pet.", "Cardiology" },
                    { 6, "We focus on preventive veterinary care to promote and improve overall pet health. Routine check-ups allow us to diagnose, treat and protect your pet from contracting serious, costly and sometimes fatal diseases. Offering a holistic approach to pet health, we partner with our clients to make sure their pets receive proper preventive", "Preventive Care" },
                    { 5, "Internal medicine services cover hormonal, gastrointestinal, urinary, haematologic (blood related), respiratory, infectious, and immune-mediated diseases. The facilities at the London Veterinary Clinic are co-ordinated by Grant Petrie. In addition to an extensive review of your pet’s medical history, diagnostics always begin with a thorough physical examination and blood tests. When more information is needed, ultrasound, radiography, endoscopy, and CT imaging may be used. Our objective is to make an accurate diagnosis as rapidly as possible while at the same time putting your pet (and you) to a minimum of inconvenience.", "Internal Medicine" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "eac17ce4-a0c3-4d04-88e6-624f533c693f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "48de8157-6766-4db1-97ea-675b98e3bb6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "b5298163-bbd6-48d5-8f53-5b44adac2c07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "bac32e5b-760f-47fe-a992-3bd24a9771fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5876326c-3ff3-4a79-b3ca-cf97fcbee4c6", "337aae71-5bd2-4312-b3f5-5631dcbcc030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b88fe2cc-29c8-40cd-bf07-f71e665a8a9b", "32c5d773-aefd-47ea-a96b-c1654a4b7e5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fd65ffd-c400-4408-9dd0-60f06cd93e01", "624d6514-b70d-427a-a284-dd356b9feff3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "27fac8f9-5ba2-45de-9961-59d150e56bf5", "487a3b15-db1b-4429-960d-49365727b96f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6427a67-e4ad-4cf8-a0a3-cb5b8119eca2", "82143227-89c9-4cfd-bce0-a3a3393c8a42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c9e57f9-549f-4e28-935b-7822c4902574", "ddd8dc97-0576-499c-9420-d7db00f0d277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4342cfb9-5890-401d-a5c8-77598f4ca50e", "756e6917-ae74-404d-ada3-dd656ae149c8" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceName",
                value: "Makeup");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "ServiceName",
                value: "Castration");
        }
    }
}
