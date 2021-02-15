using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class SpecifyUserInDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "c42b1676-4808-4783-8a6a-ad23ea3b14b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "27d9924d-1926-4dc3-8b97-bc0c54f15b3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "b6563313-0828-419a-9e00-e3eff53b6c7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "2cd5e208-ca25-437a-b716-22edbb199aaf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d84775e5-1502-4c7a-aa8e-f9a35af1e591", "9e6640c0-7955-4a33-b28f-efe13a0ff0e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aedc15e0-d60f-4b7f-97de-e70171020b11", "3f056c71-8fb1-41ae-957d-91442087452e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c223c94-d66a-4b62-b37d-f9cf293adfdc", "7d528494-ecef-4d9c-8e07-40a57c97dadd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40b74f50-b6e3-4de6-a243-d23167645719", "e498d6ce-7c80-4c54-8c0f-ac92e4eb8486" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc7161bf-6ff0-4d51-8da4-6803c89208c7", "e54245ad-40d1-4b9c-a5fe-eba22e8e7b10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7aeff90c-4783-46ec-b895-fc1ee38c5c27", "7b80c29b-e631-478f-9034-31af08bc83cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cd7b1b4-7cd9-4eb4-8747-eb552a94c61c", "f8474f36-758b-42e7-87ba-4f80b8566749" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "ca457bc2-7dea-46f5-9bc9-37cbfc004e7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "e7525e47-1b89-4f47-b85d-6159d7de788c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "5fa32539-c6cb-444d-bf5b-02cb5b57a97b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "613e3d3a-b670-45af-9796-0f7a83b5d2b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "a79077dd-978f-4c55-8fc4-60a8e4843452", "User", "78255359-2d40-444a-9d27-03101aa8fa41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "6af4ac1a-faeb-4a61-b4b0-496633a6274a", "User", "44cc9c86-44e4-4e23-b368-f5df2989b074" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "0446cc17-808a-4e8b-b0c8-12696f728400", "User", "cece6101-54b0-4370-804e-be3c3fc102f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "12f49f86-7999-44f4-95b7-f1429e5d412d", "User", "f815895d-7bb1-4d7e-b8df-0f6e57774dbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "be976714-8c54-4617-aeba-875bc96af929", "User", "729432e2-20ea-45c7-8c41-ef2e5c8ef1fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "b2924eba-d93d-4737-bbe4-854fdfba2752", "User", "47324e03-4939-43b9-9de6-40479eb286b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "694a6725-0c23-4c87-b97b-bb18e28c3379", "User", "a6f4766e-89d9-417d-89f4-5d60813f3ad0" });
        }
    }
}
