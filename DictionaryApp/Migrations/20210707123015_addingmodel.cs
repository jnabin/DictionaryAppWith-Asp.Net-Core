using Microsoft.EntityFrameworkCore.Migrations;

namespace DictionaryApp.Migrations
{
    public partial class addingmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BanglaWords",
                columns: table => new
                {
                    BanglaWordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    text = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanglaWords", x => x.BanglaWordId);
                });

            migrationBuilder.CreateTable(
                name: "BanglaWordMappings",
                columns: table => new
                {
                    BanglaWordMappingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WordId = table.Column<int>(type: "INTEGER", nullable: false),
                    BanglaWordId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanglaWordMappings", x => x.BanglaWordMappingId);
                    table.ForeignKey(
                        name: "FK_BanglaWordMappings_BanglaWords_BanglaWordId",
                        column: x => x.BanglaWordId,
                        principalTable: "BanglaWords",
                        principalColumn: "BanglaWordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BanglaWordMappings_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "WordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanglaWordMappings_BanglaWordId",
                table: "BanglaWordMappings",
                column: "BanglaWordId");

            migrationBuilder.CreateIndex(
                name: "IX_BanglaWordMappings_WordId",
                table: "BanglaWordMappings",
                column: "WordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BanglaWordMappings");

            migrationBuilder.DropTable(
                name: "BanglaWords");
        }
    }
}
