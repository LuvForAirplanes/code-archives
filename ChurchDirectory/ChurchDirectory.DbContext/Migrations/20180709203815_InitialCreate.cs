using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurchDirectory.DbContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "children",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    ParentId = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    birthdate = table.Column<DateTime>(nullable: false),
                    deathdate = table.Column<string>(nullable: true),
                    married = table.Column<string>(nullable: true),
                    member = table.Column<bool>(nullable: false),
                    comment1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_children", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "families",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    record_number = table.Column<string>(nullable: true),
                    first_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    parent_id = table.Column<string>(nullable: true),
                    birthdate = table.Column<DateTime>(nullable: true),
                    deathdate = table.Column<DateTime>(nullable: true),
                    marrieddate = table.Column<DateTime>(nullable: true),
                    spouse = table.Column<string>(nullable: true),
                    spouse_id = table.Column<string>(nullable: true),
                    spouse_birthdate = table.Column<DateTime>(nullable: true),
                    spouse_deathdate = table.Column<DateTime>(nullable: true),
                    line1 = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip = table.Column<string>(nullable: true),
                    member = table.Column<string>(nullable: true),
                    phone1 = table.Column<string>(nullable: true),
                    phone2 = table.Column<string>(nullable: true),
                    comment1 = table.Column<string>(nullable: true),
                    comment2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_families", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "children");

            migrationBuilder.DropTable(
                name: "families");
        }
    }
}
