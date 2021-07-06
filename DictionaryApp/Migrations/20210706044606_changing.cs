using Microsoft.EntityFrameworkCore.Migrations;

namespace DictionaryApp.Migrations
{
    public partial class changing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "text",
                table: "ProNouns");

            migrationBuilder.DropColumn(
                name: "text",
                table: "Nouns");

            migrationBuilder.AddColumn<int>(
                name: "ProNounMappingWordId",
                table: "ProNouns",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NounMappingWordId",
                table: "Nouns",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProNouns_ProNounMappingWordId",
                table: "ProNouns",
                column: "ProNounMappingWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Nouns_NounMappingWordId",
                table: "Nouns",
                column: "NounMappingWordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nouns_Words_NounMappingWordId",
                table: "Nouns",
                column: "NounMappingWordId",
                principalTable: "Words",
                principalColumn: "WordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProNouns_Words_ProNounMappingWordId",
                table: "ProNouns",
                column: "ProNounMappingWordId",
                principalTable: "Words",
                principalColumn: "WordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nouns_Words_NounMappingWordId",
                table: "Nouns");

            migrationBuilder.DropForeignKey(
                name: "FK_ProNouns_Words_ProNounMappingWordId",
                table: "ProNouns");

            migrationBuilder.DropIndex(
                name: "IX_ProNouns_ProNounMappingWordId",
                table: "ProNouns");

            migrationBuilder.DropIndex(
                name: "IX_Nouns_NounMappingWordId",
                table: "Nouns");

            migrationBuilder.DropColumn(
                name: "ProNounMappingWordId",
                table: "ProNouns");

            migrationBuilder.DropColumn(
                name: "NounMappingWordId",
                table: "Nouns");

            migrationBuilder.AddColumn<string>(
                name: "text",
                table: "ProNouns",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "text",
                table: "Nouns",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
