using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class FixedInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actors_movies_actors_actorId",
                table: "actors_movies");

            migrationBuilder.DropForeignKey(
                name: "FK_actors_movies_movies_movieId",
                table: "actors_movies");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_cenimas_cenimaId",
                table: "movies");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_producers_producerId",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producers",
                table: "producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movies",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cenimas",
                table: "cenimas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actors_movies",
                table: "actors_movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actors",
                table: "actors");

            migrationBuilder.RenameTable(
                name: "producers",
                newName: "Producers");

            migrationBuilder.RenameTable(
                name: "movies",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "cenimas",
                newName: "Cenimas");

            migrationBuilder.RenameTable(
                name: "actors_movies",
                newName: "Actors_Movies");

            migrationBuilder.RenameTable(
                name: "actors",
                newName: "Actors");

            migrationBuilder.RenameColumn(
                name: "profilePictureURL",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "bio",
                table: "Producers",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "producerId",
                table: "Producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Movies",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "producerId",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Movies",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Movies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "movieCategory",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameColumn(
                name: "imageURL",
                table: "Movies",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Movies",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "cenimaId",
                table: "Movies",
                newName: "CenimaId");

            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_movies_producerId",
                table: "Movies",
                newName: "IX_Movies_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_movies_cenimaId",
                table: "Movies",
                newName: "IX_Movies_CenimaId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Cenimas",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Cenimas",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Cenimas",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "cenimaId",
                table: "Cenimas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "actorId",
                table: "Actors_Movies",
                newName: "ActorId");

            migrationBuilder.RenameIndex(
                name: "IX_actors_movies_movieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.RenameColumn(
                name: "profilePictureURL",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "bio",
                table: "Actors",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "actorId",
                table: "Actors",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cenimas",
                table: "Cenimas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cenimas_CenimaId",
                table: "Movies",
                column: "CenimaId",
                principalTable: "Cenimas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cenimas_CenimaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cenimas",
                table: "Cenimas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "producers");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "movies");

            migrationBuilder.RenameTable(
                name: "Cenimas",
                newName: "cenimas");

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "actors_movies");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "actors");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "producers",
                newName: "profilePictureURL");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "producers",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "producers",
                newName: "bio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "producers",
                newName: "producerId");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "movies",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "movies",
                newName: "producerId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "movies",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "movies",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "movies",
                newName: "movieCategory");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "movies",
                newName: "imageURL");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "movies",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "movies",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CenimaId",
                table: "movies",
                newName: "cenimaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "movies",
                newName: "movieId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerId",
                table: "movies",
                newName: "IX_movies_producerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CenimaId",
                table: "movies",
                newName: "IX_movies_cenimaId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "cenimas",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "cenimas",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "cenimas",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "cenimas",
                newName: "cenimaId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "actors_movies",
                newName: "movieId");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "actors_movies",
                newName: "actorId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "actors_movies",
                newName: "IX_actors_movies_movieId");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "actors",
                newName: "profilePictureURL");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "actors",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "actors",
                newName: "bio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "actors",
                newName: "actorId");

            migrationBuilder.AlterColumn<string>(
                name: "startDate",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "endDate",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producers",
                table: "producers",
                column: "producerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movies",
                table: "movies",
                column: "movieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cenimas",
                table: "cenimas",
                column: "cenimaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actors_movies",
                table: "actors_movies",
                columns: new[] { "actorId", "movieId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_actors",
                table: "actors",
                column: "actorId");

            migrationBuilder.AddForeignKey(
                name: "FK_actors_movies_actors_actorId",
                table: "actors_movies",
                column: "actorId",
                principalTable: "actors",
                principalColumn: "actorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_actors_movies_movies_movieId",
                table: "actors_movies",
                column: "movieId",
                principalTable: "movies",
                principalColumn: "movieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_cenimas_cenimaId",
                table: "movies",
                column: "cenimaId",
                principalTable: "cenimas",
                principalColumn: "cenimaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_producers_producerId",
                table: "movies",
                column: "producerId",
                principalTable: "producers",
                principalColumn: "producerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
