using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace comunida.Data.Migrations
{
    public partial class organizationrequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Requirements",
                table: "Organization",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Requirements",
                table: "Organization");
        }
    }
}
