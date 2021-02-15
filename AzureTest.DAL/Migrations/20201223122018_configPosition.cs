using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class configPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Positions_PositionId",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "b3f9b79b-579e-4336-a3e1-718deabebbe0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "993c8237-81b0-4f47-a7c3-6eaae952969e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "a261ea84-c275-4329-af8e-90abd1d81bd5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "0b4f82b5-c01b-45f7-9c36-973031966b05");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51dd4f15-f21e-4806-b3a0-32b972e76aa1", "f6ed47f3-43e9-434d-832c-df8de5553979" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "683f579a-129d-4803-96de-793401a6b692", "437164b3-8f6c-46cf-92ea-0d00befad577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac9c014d-e363-48d9-871e-359486765b7c", "d4ed0aa7-7a71-4ae9-98bd-f135cc98318d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccb5d309-9064-4f45-85af-d41fbea3f5c3", "b224c660-237c-4d8b-8304-b919063530b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90fd5882-39b1-4ec9-bb80-0e776d5adeea", "e2187be4-b790-4e40-9e2c-164fc87a03ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cfec8a08-929e-48b1-82c7-e0cfe3211b12", "ba779e37-1408-4303-8180-c1bc4decb7cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51f4e441-67c7-4466-9e76-e966dc45e291", "1b76bd5a-5a7f-4bd1-a176-8878e51d1fd5" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Positions_PositionId",
                table: "Doctors",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Positions_PositionId",
                table: "Doctors");

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02c2713c-ea07-4604-9c20-90a2fa32f7de", "69211cf1-77af-46c4-b66f-70bdd3499413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cefe91c8-1d78-48e5-a52b-14d21b06bd2b", "dca41019-f980-4a79-a167-e220b83093ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "678fede0-b293-456c-82f3-db40ed43f5b1", "efdb8b6a-b479-4b5d-a6ac-f33b5b6f7b4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "013ce621-3391-4c1b-bc57-0b3bfa886596", "29018ba6-c102-4647-b53d-bdac94eab571" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "111801f1-9071-4299-a553-ca71d079d1b2", "6adf87bd-ec01-4cfd-bb87-c11e2ebc7820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd8cfd29-6bf6-4070-ba45-896f9f2998d2", "1998233a-fbbb-436b-a724-47cb844fb525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9cf0881d-8f76-497d-9bcb-a8ccde3d8cc4", "d30aa8c7-896b-4a6f-a0b3-ad349d212d09" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Positions_PositionId",
                table: "Doctors",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
