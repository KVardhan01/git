using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FCodeCRUD.Migrations
{
    /// <inheritdoc />
    public partial class initialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    UserEmail = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUsers", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TUsers");
        }
    }
}
