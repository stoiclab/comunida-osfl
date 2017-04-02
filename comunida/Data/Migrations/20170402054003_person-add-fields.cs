using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace comunida.Data.Migrations
{
    public partial class personaddfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AspNetUsers_Person_PersonID",
            //    table: "AspNetUsers");

            //migrationBuilder.DropIndex(
            //    name: "IX_AspNetUsers_PersonID",
            //    table: "AspNetUsers");

            //migrationBuilder.DropColumn(
            //    name: "PersonID",
            //    table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "about",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "availability",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telephone",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "about",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "availability",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "telephone",
                table: "Person");

            //migrationBuilder.AddColumn<int>(
            //    name: "PersonID",
            //    table: "AspNetUsers",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUsers_PersonID",
            //    table: "AspNetUsers",
            //    column: "PersonID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Person_PersonID",
            //    table: "AspNetUsers",
            //    column: "PersonID",
            //    principalTable: "Person",
            //    principalColumn: "ID",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
