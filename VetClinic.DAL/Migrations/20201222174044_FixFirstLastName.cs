using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class FixFirstLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TreatmentDescription",
                table: "Appointments",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Appointments",
                nullable: false,
                defaultValue: 3,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Complaints",
                table: "Appointments",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "dd206201-fc8a-4209-9e44-5292ab52c274");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "773c257e-8d96-47f7-8b73-5908872107b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "56590194-6e5a-49ff-8d35-5821ea38d591");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "f62176e0-d1ce-4e07-b775-0902a457b937");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "02c2713c-ea07-4604-9c20-90a2fa32f7de", "69211cf1-77af-46c4-b66f-70bdd3499413", "Anastasiya", "Koleso" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "cefe91c8-1d78-48e5-a52b-14d21b06bd2b", "dca41019-f980-4a79-a167-e220b83093ea", "Oleh", "Nazarenko" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "678fede0-b293-456c-82f3-db40ed43f5b1", "efdb8b6a-b479-4b5d-a6ac-f33b5b6f7b4b", "Shuba", "Noorkova" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "013ce621-3391-4c1b-bc57-0b3bfa886596", "29018ba6-c102-4647-b53d-bdac94eab571", "Andriy", "Vozniy" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "111801f1-9071-4299-a553-ca71d079d1b2", "6adf87bd-ec01-4cfd-bb87-c11e2ebc7820", "Maruna", "Kosovich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "bd8cfd29-6bf6-4070-ba45-896f9f2998d2", "1998233a-fbbb-436b-a724-47cb844fb525", "Ivan", "Wernudub" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "9cf0881d-8f76-497d-9bcb-a8ccde3d8cc4", "d30aa8c7-896b-4a6f-a0b3-ad349d212d09", "Nadiya", "Mukolenko" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TreatmentDescription",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Appointments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Complaints",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "0fdde684-8fff-43a3-8f29-fa3c417f2e99");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "b3218d73-dce5-4082-8e35-2b93c268ff90");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "ebe8bf9c-86dd-4c92-9582-74b667a867a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "efc3aeed-6267-49bb-b28a-bc6215c8b97a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "0a0ff5c7-813b-4b82-9025-27c744feab01", "5f06386c-ff3b-47e8-8235-b1cbe88b8c91", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "56184e50-dc1e-4fde-be73-03e765af11e3", "8a74c4a3-cf05-41d1-86f0-a9d857ccf526", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "e9cd709f-1237-4cf5-83df-30259405c658", "944a4ec1-6204-4977-8b21-4f583e089a58", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "7ef436e8-2ee7-4d43-9f78-9168b351490a", "b1fa9873-1201-4149-9783-0fe6a20578a0", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "e31961c7-cb87-49e8-9a87-f99558ad7e11", "1f2e1b93-65ee-4bd2-886c-d2bf11666152", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "e1225141-a969-448a-8ee2-9b17a2f3005a", "4ff494b0-bebc-43c0-a408-382ddf6c9b05", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "FirstName", "LastName" },
                values: new object[] { "ddf5515d-0024-43e3-96f2-340387ba9a9a", "0bb7f018-73f2-4e94-beb8-4db71532fbdb", null, null });
        }
    }
}
