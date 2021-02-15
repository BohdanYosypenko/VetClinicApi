using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class AppointmentMigration : Migration
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c56a3bcf-57cf-499f-9ca6-80348c31ab15", "e3411cc0-4999-4bf6-9561-846b9f4c0150" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f565619f-d9c3-4748-ae44-5347e661d365", "20917fd6-8e62-4bee-af36-c086f1f1bf4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5d2a95c-6261-4029-aadc-2e3cc7326be4", "7fab7a3f-170e-4708-9d9b-47af9b78c7cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7495af9-dc67-4367-a5e1-32b476a0c1d8", "36fe0377-d9f9-43fa-b63d-369a45ffbc95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5d4238c-cdd8-46f2-a6a3-eabdd8045c1d", "2dbf6734-49a7-4739-878b-816ef112e114" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc6f8d6a-fb30-4f19-9f7d-eacfcacea582", "537ae340-1672-4a5b-8e1d-344833baf40c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "090f8de9-8eb0-4c9b-ada4-a5e86f083896", "7ec707cd-d54b-42fe-abf0-1fb692911782" });
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
