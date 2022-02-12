using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurchDirectory.DbContext.Migrations
{
    public partial class RemoveChildList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_children_families_FamilyId",
                table: "children");

            migrationBuilder.DropIndex(
                name: "IX_children_FamilyId",
                table: "children");

            migrationBuilder.DropColumn(
                name: "FamilyId",
                table: "children");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FamilyId",
                table: "children",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_children_FamilyId",
                table: "children",
                column: "FamilyId");

            migrationBuilder.AddForeignKey(
                name: "FK_children_families_FamilyId",
                table: "children",
                column: "FamilyId",
                principalTable: "families",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
