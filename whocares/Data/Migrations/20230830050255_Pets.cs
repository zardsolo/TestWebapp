using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection.Metadata;

#nullable disable

namespace puppyPlayDates.Data.Migrations
{
    public partial class CreateTableUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        migrationBuilder.CreateTable(
            name: "Pets",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PetName = table.Column<string>(maxLength: 256, nullable: true),
                    PetBreed = table.Column<string>(maxLength: 256, nullable: true),
                    PetAge = table.Column<int>(maxLength: 256, nullable: true),
                    PetGender = table.Column<string>(maxLength: 256, nullable: true),
                    PetImage = table.Column<Blob>(nullable: true),

                });

        }
    }
}
