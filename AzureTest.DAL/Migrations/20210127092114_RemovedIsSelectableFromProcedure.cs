using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class RemovedIsSelectableFromProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelectable",
                table: "Procedures");

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a79077dd-978f-4c55-8fc4-60a8e4843452", "78255359-2d40-444a-9d27-03101aa8fa41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6af4ac1a-faeb-4a61-b4b0-496633a6274a", "44cc9c86-44e4-4e23-b368-f5df2989b074" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0446cc17-808a-4e8b-b0c8-12696f728400", "cece6101-54b0-4370-804e-be3c3fc102f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12f49f86-7999-44f4-95b7-f1429e5d412d", "f815895d-7bb1-4d7e-b8df-0f6e57774dbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be976714-8c54-4617-aeba-875bc96af929", "729432e2-20ea-45c7-8c41-ef2e5c8ef1fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2924eba-d93d-4737-bbe4-854fdfba2752", "47324e03-4939-43b9-9de6-40479eb286b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "694a6725-0c23-4c87-b97b-bb18e28c3379", "a6f4766e-89d9-417d-89f4-5d60813f3ad0" });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProcedureName",
                value: "SPA procedure");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelectable",
                table: "Procedures",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                table: "Procedures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsSelectable", "ProcedureName" },
                values: new object[] { true, "SPA procedures" });

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsSelectable",
                value: true);
        }
    }
}
