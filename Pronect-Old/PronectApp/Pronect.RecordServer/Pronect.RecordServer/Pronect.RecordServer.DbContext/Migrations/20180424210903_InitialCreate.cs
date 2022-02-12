using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronect.RecordServer.DbContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "connnection_records",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    host = table.Column<string>(nullable: true),
                    remote = table.Column<string>(nullable: true),
                    start_time = table.Column<string>(nullable: true),
                    end_time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_connnection_records", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "connnection_records");
        }
    }
}
