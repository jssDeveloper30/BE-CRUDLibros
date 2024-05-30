using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_CRUDLibros.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    isbn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaPublicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    editorial = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.isbn);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libro");
        }
    }
}
