using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseFinal.Migrations
{
    public partial class SecondDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Animes_AnimeId",
                table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_ShowsHaveGenres_Animes_AnimeId",
                table: "ShowsHaveGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_ShowsHaveGenres_Genres_GenreId",
                table: "ShowsHaveGenres");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "ShowsHaveGenres",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimeId",
                table: "ShowsHaveGenres",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimeId",
                table: "Seasons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Animes_AnimeId",
                table: "Seasons",
                column: "AnimeId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShowsHaveGenres_Animes_AnimeId",
                table: "ShowsHaveGenres",
                column: "AnimeId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShowsHaveGenres_Genres_GenreId",
                table: "ShowsHaveGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Animes_AnimeId",
                table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_ShowsHaveGenres_Animes_AnimeId",
                table: "ShowsHaveGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_ShowsHaveGenres_Genres_GenreId",
                table: "ShowsHaveGenres");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "ShowsHaveGenres",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AnimeId",
                table: "ShowsHaveGenres",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AnimeId",
                table: "Seasons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Animes_AnimeId",
                table: "Seasons",
                column: "AnimeId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShowsHaveGenres_Animes_AnimeId",
                table: "ShowsHaveGenres",
                column: "AnimeId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShowsHaveGenres_Genres_GenreId",
                table: "ShowsHaveGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
