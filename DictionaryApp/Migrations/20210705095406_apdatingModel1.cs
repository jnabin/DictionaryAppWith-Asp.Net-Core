using Microsoft.EntityFrameworkCore.Migrations;

namespace DictionaryApp.Migrations
{
    public partial class apdatingModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProNoun_Words_WordId",
                table: "ProNoun");

            migrationBuilder.DropForeignKey(
                name: "FK_WordSentence_Sentence_SentenceId",
                table: "WordSentence");

            migrationBuilder.DropForeignKey(
                name: "FK_WordSentence_Words_WordId",
                table: "WordSentence");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WordSentence",
                table: "WordSentence");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sentence",
                table: "Sentence");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProNoun",
                table: "ProNoun");

            migrationBuilder.RenameTable(
                name: "WordSentence",
                newName: "WordSentences");

            migrationBuilder.RenameTable(
                name: "Sentence",
                newName: "Sentences");

            migrationBuilder.RenameTable(
                name: "ProNoun",
                newName: "ProNouns");

            migrationBuilder.RenameIndex(
                name: "IX_WordSentence_WordId",
                table: "WordSentences",
                newName: "IX_WordSentences_WordId");

            migrationBuilder.RenameIndex(
                name: "IX_WordSentence_SentenceId",
                table: "WordSentences",
                newName: "IX_WordSentences_SentenceId");

            migrationBuilder.RenameIndex(
                name: "IX_ProNoun_WordId",
                table: "ProNouns",
                newName: "IX_ProNouns_WordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WordSentences",
                table: "WordSentences",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sentences",
                table: "Sentences",
                column: "SentenceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProNouns",
                table: "ProNouns",
                column: "ProNounId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProNouns_Words_WordId",
                table: "ProNouns",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "WordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordSentences_Sentences_SentenceId",
                table: "WordSentences",
                column: "SentenceId",
                principalTable: "Sentences",
                principalColumn: "SentenceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordSentences_Words_WordId",
                table: "WordSentences",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "WordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProNouns_Words_WordId",
                table: "ProNouns");

            migrationBuilder.DropForeignKey(
                name: "FK_WordSentences_Sentences_SentenceId",
                table: "WordSentences");

            migrationBuilder.DropForeignKey(
                name: "FK_WordSentences_Words_WordId",
                table: "WordSentences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WordSentences",
                table: "WordSentences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sentences",
                table: "Sentences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProNouns",
                table: "ProNouns");

            migrationBuilder.RenameTable(
                name: "WordSentences",
                newName: "WordSentence");

            migrationBuilder.RenameTable(
                name: "Sentences",
                newName: "Sentence");

            migrationBuilder.RenameTable(
                name: "ProNouns",
                newName: "ProNoun");

            migrationBuilder.RenameIndex(
                name: "IX_WordSentences_WordId",
                table: "WordSentence",
                newName: "IX_WordSentence_WordId");

            migrationBuilder.RenameIndex(
                name: "IX_WordSentences_SentenceId",
                table: "WordSentence",
                newName: "IX_WordSentence_SentenceId");

            migrationBuilder.RenameIndex(
                name: "IX_ProNouns_WordId",
                table: "ProNoun",
                newName: "IX_ProNoun_WordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WordSentence",
                table: "WordSentence",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sentence",
                table: "Sentence",
                column: "SentenceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProNoun",
                table: "ProNoun",
                column: "ProNounId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProNoun_Words_WordId",
                table: "ProNoun",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "WordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordSentence_Sentence_SentenceId",
                table: "WordSentence",
                column: "SentenceId",
                principalTable: "Sentence",
                principalColumn: "SentenceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordSentence_Words_WordId",
                table: "WordSentence",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "WordId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
