using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VetClinic.DAL.Migrations
{
    public partial class MasterMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalTypeName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 50, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 300, nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 12, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(maxLength: 40, nullable: true),
                    Salary = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcedureName = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    IsSelectable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Education = table.Column<string>(maxLength: 100, nullable: true),
                    Biography = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(maxLength: 200, nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    PositionId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(maxLength: 150, nullable: true),
                    ClientId = table.Column<int>(nullable: false),
                    AnimalTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_AnimalTypes_AnimalTypeId",
                        column: x => x.AnimalTypeId,
                        principalTable: "AnimalTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateTime>(nullable: false),
                    Complaints = table.Column<string>(nullable: true),
                    TreatmentDescription = table.Column<string>(nullable: true),
                    DoctorId = table.Column<int>(nullable: true),
                    AnimalId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(nullable: false),
                    ProcedureId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentProcedures_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentProcedures_Procedures_ProcedureId",
                        column: x => x.ProcedureId,
                        principalTable: "Procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "Id", "AnimalTypeName" },
                values: new object[,]
                {
                    { 1, "Pes dvorovuy" },
                    { 2, "Kit Domashniy" },
                    { 3, "Slon" },
                    { 4, "Zhuraph" },
                    { 5, "Zolota Rubka" },
                    { 6, "Homyak" },
                    { 7, "Monster" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, "5ab93c35-b2be-4bb9-b58c-fdf70621dbfc", "User", "KosovichMaruna@gmail.com", false, false, null, null, null, null, "0681236324", false, "9a84f6b5-5d50-4736-86ce-79f9aadbdce2", false, "Kosovich Maruna" },
                    { "4", 0, "732d617f-9ec7-4e33-b631-df9c4fb7f3c4", "User", "VozniyAndriy@gmail.com", false, false, null, null, null, null, "0931412622", false, "40f85397-45b6-432d-a711-93df2c1cce5e", false, "Vozniy Andriy" },
                    { "3", 0, "07c750ca-53f9-431b-ba81-d33dcf38d19b", "User", "NoorkovaShuba@gmail.com", false, false, null, null, null, null, "0934453214", false, "adc6034b-0c0a-46a7-944f-3158ad6ead8b", false, "Noorkova Shuba" },
                    { "2", 0, "99bffdba-2d91-4eae-84d6-1a7e9b13d3d7", "User", "NazarenkoOleh@gmail.com", false, false, null, null, null, null, "0954453374", false, "3d511176-f5f4-428a-a874-a2833d2ba4d6", false, "Nazarenko Oleh" },
                    { "1", 0, "199d8f6c-f299-4ce5-a80a-27d2e74a1457", "User", "KolesoAnastasiya@gmail.com", false, false, null, null, null, null, "0984112333", false, "feb42154-f76e-43e9-831e-9ef53ab4a35b", false, "Koleso Anastasiya" },
                    { "6", 0, "e54ff86e-7866-4993-87fb-d1a7285ee8e4", "User", "WernudubIvan@gmail.com", false, false, null, null, null, null, "0982123654", false, "d780d6ad-0156-4529-a3ca-2a47f70b72b5", false, "Wernudub Ivan" },
                    { "7", 0, "457202b1-bc96-465d-9c27-763f304a7aa6", "User", "MukolenkoNadiya@gmail.com", false, false, null, null, null, null, "0982131254", false, "2db11faa-0364-4600-b2ca-eb72f1672300", false, "Mukolenko Nadiya" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "PositionName", "Salary" },
                values: new object[,]
                {
                    { 1, "Вirector", 100000m },
                    { 2, "Сleaner", 10000m },
                    { 3, "Veterinarian", 500m },
                    { 4, "Stylist", 1000m }
                });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "Id", "Description", "IsSelectable", "Price", "ProcedureName" },
                values: new object[,]
                {
                    { 4, "Bad operation", false, 240m, "Сastration" },
                    { 1, "Best for your pet", true, 1000m, "SPA procedures" },
                    { 3, "Pet inspection", true, 50m, "Examination of animal" },
                    { 5, "Doctor Consultation about care and maintenance of the animal", false, 100m, "Consultation" },
                    { 2, "Paw fracture", false, 2000m, "Operation" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ServiceName" },
                values: new object[,]
                {
                    { 4, "Castration" },
                    { 3, "Urgently" },
                    { 2, "Makeup" },
                    { 1, "Inspection" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 1, "Approved" },
                    { 4, "Completed" },
                    { 2, "Disapproved" },
                    { 3, "Processing" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "4" },
                    { 2, "5" },
                    { 3, "6" },
                    { 4, "7" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "Education", "Experience", "Photo", "PositionId", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Gas and Oil", "2", null, 1, "1" },
                    { 2, null, "IfMedical", "7", null, 3, "2" },
                    { 3, null, "SelfEducation", "3", null, 4, "3" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalTypeId", "ClientId", "Name", "Photo" },
                values: new object[,]
                {
                    { 2, 3, 2, 1, "Ruzhuk", null },
                    { 6, 1, 6, 1, "Krug", null },
                    { 8, 2, 2, 1, "Robin", null },
                    { 3, 5, 1, 2, "Sirko", null },
                    { 1, 342, 7, 3, "Pushok", null },
                    { 7, 1, 5, 3, "Dzvin", null },
                    { 4, 12, 3, 4, "Biznes", null },
                    { 5, 4, 4, 4, "Hmarochos", null }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AnimalId", "AppointmentDate", "Complaints", "DoctorId", "ServiceId", "StatusId", "TreatmentDescription" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2020, 4, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), "Bad wool", 3, 2, 3, "Use animal shampoo" },
                    { 6, 6, new DateTime(2019, 2, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), "Vaccination", 2, 1, 3, "" },
                    { 8, 8, new DateTime(2020, 3, 30, 10, 30, 0, 0, DateTimeKind.Unspecified), "Paw fracture", 2, 3, 1, "daily bandage change" },
                    { 3, 3, new DateTime(2020, 1, 12, 10, 30, 0, 0, DateTimeKind.Unspecified), "Required castration", 2, 4, 4, "wear a collar for 12 days" },
                    { 1, 1, new DateTime(2020, 5, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), "Temperature", 1, 1, 2, "Drink more wather" },
                    { 7, 7, new DateTime(2020, 12, 12, 12, 30, 0, 0, DateTimeKind.Unspecified), "Sore spine", 2, 1, 2, "daily walk" },
                    { 4, 4, new DateTime(2019, 5, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), "Spa procedure", 3, 2, 1, "Spa every weak" },
                    { 5, 5, new DateTime(2019, 11, 15, 12, 30, 0, 0, DateTimeKind.Unspecified), "Need consultation", 3, 1, 4, "Pay more attention" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentProcedures",
                columns: new[] { "Id", "AppointmentId", "ProcedureId" },
                values: new object[,]
                {
                    { 2, 2, 2 },
                    { 6, 6, 3 },
                    { 9, 8, 4 },
                    { 3, 3, 3 },
                    { 1, 1, 1 },
                    { 10, 1, 3 },
                    { 7, 7, 5 },
                    { 8, 7, 4 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_ClientId",
                table: "Animals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentProcedures_AppointmentId",
                table: "AppointmentProcedures",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentProcedures_ProcedureId",
                table: "AppointmentProcedures",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AnimalId",
                table: "Appointments",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_StatusId",
                table: "Appointments",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PositionId",
                table: "Doctors",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentProcedures");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "AnimalTypes");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
