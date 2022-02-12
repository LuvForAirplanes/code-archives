using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronect.UserAccountServer.DbContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user_accounts",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    license_key = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    date_acquired = table.Column<string>(nullable: true),
                    owners_name = table.Column<string>(nullable: true),
                    devices = table.Column<string>(nullable: true),
                    watched_devices = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_accounts", x => x.id);
                });

            InitialSeedData.InitialSeeding(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_accounts");
        }
    }
}
