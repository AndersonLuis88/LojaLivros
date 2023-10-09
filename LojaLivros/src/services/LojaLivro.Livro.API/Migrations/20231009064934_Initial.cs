using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaLivro.Livro.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(500)", nullable: false),
                    Isbn = table.Column<string>(type: "varchar(250)", nullable: false),
                    Editora = table.Column<string>(type: "varchar(250)", nullable: false),
                    Autor = table.Column<string>(type: "varchar(250)", nullable: false),
                    Sinopse = table.Column<string>(type: "varchar(250)", nullable: false),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    Imagem = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
