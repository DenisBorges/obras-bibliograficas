using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ObrasBibliograficas.DataAcess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data_Cadastro = table.Column<DateTime>(nullable: true),
                    Data_Atualizacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 30, nullable: false),
                    NomedoMeio = table.Column<string>(maxLength: 30, nullable: true),
                    Sobrenome = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autor");
        }
    }
}
