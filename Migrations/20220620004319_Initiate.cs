using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVeffort.Migrations
{
    public partial class Initiate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamagedUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        /*.Annotation("SqlServer:Identity", "1, 1")*/,
                    A1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    H15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PipeEnding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhenAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WhoAdded = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamagedUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "DamagedUnits");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
