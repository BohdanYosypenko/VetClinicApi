using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class AddUserService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Clients_UserId",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Clients_UserId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "199d8f6c-f299-4ce5-a80a-27d2e74a1457", "feb42154-f76e-43e9-831e-9ef53ab4a35b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99bffdba-2d91-4eae-84d6-1a7e9b13d3d7", "3d511176-f5f4-428a-a874-a2833d2ba4d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07c750ca-53f9-431b-ba81-d33dcf38d19b", "adc6034b-0c0a-46a7-944f-3158ad6ead8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "732d617f-9ec7-4e33-b631-df9c4fb7f3c4", "40f85397-45b6-432d-a711-93df2c1cce5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ab93c35-b2be-4bb9-b58c-fdf70621dbfc", "9a84f6b5-5d50-4736-86ce-79f9aadbdce2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e54ff86e-7866-4993-87fb-d1a7285ee8e4", "d780d6ad-0156-4529-a3ca-2a47f70b72b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "457202b1-bc96-465d-9c27-763f304a7aa6", "2db11faa-0364-4600-b2ca-eb72f1672300" });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId");
        }
    }
}
