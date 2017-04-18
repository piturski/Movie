using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class TypeOfQualitySetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QualityType",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "TypeOfQualitySetting",
                table: "Movie",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfQualitySetting",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "QualityType",
                table: "Movie",
                nullable: false,
                defaultValue: 0);
        }
    }
}
