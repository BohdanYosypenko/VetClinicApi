using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class RoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "542636ae-953e-4e04-a7de-7533f25af173", "0fdde684-8fff-43a3-8f29-fa3c417f2e99", "client", "CLIENT" },
                    { "e65dd8e1-34f8-4e9d-b535-3b03dde2500e", "efc3aeed-6267-49bb-b28a-bc6215c8b97a", "doctor", "DOCTOR" },
                    { "9149c77e-5c15-416a-9bed-e361330feb92", "b3218d73-dce5-4082-8e35-2b93c268ff90", "admin", "ADMIN" },
                    { "ced370e3-1401-4190-9960-ab5bf41f162e", "ebe8bf9c-86dd-4c92-9582-74b667a867a8", "accountant", "ACCOUNTANT" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a0ff5c7-813b-4b82-9025-27c744feab01", "5f06386c-ff3b-47e8-8235-b1cbe88b8c91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56184e50-dc1e-4fde-be73-03e765af11e3", "8a74c4a3-cf05-41d1-86f0-a9d857ccf526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9cd709f-1237-4cf5-83df-30259405c658", "944a4ec1-6204-4977-8b21-4f583e089a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ef436e8-2ee7-4d43-9f78-9168b351490a", "b1fa9873-1201-4149-9783-0fe6a20578a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e31961c7-cb87-49e8-9a87-f99558ad7e11", "1f2e1b93-65ee-4bd2-886c-d2bf11666152" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1225141-a969-448a-8ee2-9b17a2f3005a", "4ff494b0-bebc-43c0-a408-382ddf6c9b05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ddf5515d-0024-43e3-96f2-340387ba9a9a", "0bb7f018-73f2-4e94-beb8-4db71532fbdb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80b15a9f-96c3-4f7b-9fc1-a19a07c36703", "70fed886-9b33-4247-8926-7c8afb8ec199" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7057a228-e6a9-4245-8e36-03e8862702c2", "60e4e0a4-d90e-4e35-8fd7-c09b07b4ab56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51532d56-dd05-4a52-9948-9a5d30b5da6d", "7b9c0ff3-7cc2-4649-bd99-6f955f456883" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03e014cd-68d5-429a-ba98-11887a780fec", "5c81c2b2-4287-446a-8596-b93ad4f43b40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "890fcfbe-4760-4afe-9e68-d447cab064ba", "def2b3e0-b4e0-4ad6-bba1-1cb2e9d818b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bf036a59-f2e4-4625-88cb-e8810aea8aab", "b330182e-28dd-4243-9c74-cb9b14349944" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5293d30c-edd8-4465-9b94-ff9ce62c75ea", "a5048b25-4e7e-4c3a-8c38-f156ef3f37b3" });
        }
    }
}
