﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Repositories.Migrations
{
    public partial class AddDoctorToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDoctor",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDoctor",
                table: "AspNetUsers");
        }
    }
}
