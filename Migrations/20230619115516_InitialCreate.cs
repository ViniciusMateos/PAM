using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FUSCA_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entregas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Local_Entrega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Entrega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hr_Entrega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Entrega = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Entregas",
                columns: new[] { "Id", "Dt_Entrega", "Hr_Entrega", "Local_Entrega", "Tipo_Entrega" },
                values: new object[,]
                {
                    { 1, "01/05/1760", "10:10", "Rua São João", "Sedex" },
                    { 2, "02/05/1760", "11:11", "Rua Santo Antônio", "ONG" },
                    { 3, "03/05/1760", "22:22", "Rua Santa Maria", "Sedex" },
                    { 4, "04/05/1760", "09:09", "Rua Josino", "ONG" },
                    { 5, "05/05/1760", "08:08", "Rua do Vieira", "Retirada" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entregas");
        }
    }
}
