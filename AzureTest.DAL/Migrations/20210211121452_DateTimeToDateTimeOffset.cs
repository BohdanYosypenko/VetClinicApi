using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class DateTimeToDateTimeOffset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AppointmentDate",
                table: "Appointments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542636ae-953e-4e04-a7de-7533f25af173",
                column: "ConcurrencyStamp",
                value: "dd0c5bb2-d9d0-4d90-ad85-0c159a393c34");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9149c77e-5c15-416a-9bed-e361330feb92",
                column: "ConcurrencyStamp",
                value: "3bdfb39d-4785-466a-b0c4-771a19cd6352");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced370e3-1401-4190-9960-ab5bf41f162e",
                column: "ConcurrencyStamp",
                value: "f983fa65-8725-477f-8ea0-b31349e6748f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65dd8e1-34f8-4e9d-b535-3b03dde2500e",
                column: "ConcurrencyStamp",
                value: "a44c9009-3ec9-468f-a6cb-73d84321a054");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));

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
        }
    }
}
