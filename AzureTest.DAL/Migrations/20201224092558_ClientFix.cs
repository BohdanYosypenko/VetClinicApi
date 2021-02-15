using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class ClientFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
