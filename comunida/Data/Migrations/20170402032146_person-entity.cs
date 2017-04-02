using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace comunida.Data.Migrations
{
    public partial class personentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interest_AspNetUsers_UserId",
                table: "Interest");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Interest",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Interest_UserId",
                table: "Interest",
                newName: "IX_Interest_ApplicationUserId");

            migrationBuilder.AddColumn<int>(
                name: "PersonOrganizationInterestId",
                table: "Organization",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Interest",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonOrganizationInterestId",
                table: "Interest",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserOrganizationInterest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InterestId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrganizationInterest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonOrganizationInterestId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Person_UserOrganizationInterest_PersonOrganizationInterestId",
                        column: x => x.PersonOrganizationInterestId,
                        principalTable: "UserOrganizationInterest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organization_PersonOrganizationInterestId",
                table: "Organization",
                column: "PersonOrganizationInterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Interest_PersonID",
                table: "Interest",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Interest_PersonOrganizationInterestId",
                table: "Interest",
                column: "PersonOrganizationInterestId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonID",
                table: "AspNetUsers",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonOrganizationInterestId",
                table: "Person",
                column: "PersonOrganizationInterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Person_PersonID",
                table: "AspNetUsers",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_AspNetUsers_ApplicationUserId",
                table: "Interest",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_Person_PersonID",
                table: "Interest",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_UserOrganizationInterest_PersonOrganizationInterestId",
                table: "Interest",
                column: "PersonOrganizationInterestId",
                principalTable: "UserOrganizationInterest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_UserOrganizationInterest_PersonOrganizationInterestId",
                table: "Organization",
                column: "PersonOrganizationInterestId",
                principalTable: "UserOrganizationInterest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Person_PersonID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Interest_AspNetUsers_ApplicationUserId",
                table: "Interest");

            migrationBuilder.DropForeignKey(
                name: "FK_Interest_Person_PersonID",
                table: "Interest");

            migrationBuilder.DropForeignKey(
                name: "FK_Interest_UserOrganizationInterest_PersonOrganizationInterestId",
                table: "Interest");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_UserOrganizationInterest_PersonOrganizationInterestId",
                table: "Organization");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "UserOrganizationInterest");

            migrationBuilder.DropIndex(
                name: "IX_Organization_PersonOrganizationInterestId",
                table: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Interest_PersonID",
                table: "Interest");

            migrationBuilder.DropIndex(
                name: "IX_Interest_PersonOrganizationInterestId",
                table: "Interest");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonOrganizationInterestId",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Interest");

            migrationBuilder.DropColumn(
                name: "PersonOrganizationInterestId",
                table: "Interest");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Interest",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Interest_ApplicationUserId",
                table: "Interest",
                newName: "IX_Interest_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_AspNetUsers_UserId",
                table: "Interest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
