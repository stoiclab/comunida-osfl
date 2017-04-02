using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace comunida.Data.Migrations
{
    public partial class personentityupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Person_PersonID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Person",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_UserId1",
                table: "Person",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_AspNetUsers_UserId1",
                table: "Person",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_AspNetUsers_UserId1",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_UserId1",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonID",
                table: "AspNetUsers",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Person_PersonID",
                table: "AspNetUsers",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
