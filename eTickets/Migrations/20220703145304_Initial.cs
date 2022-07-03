using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actors",
                columns: table => new
                {
                    actorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors", x => x.actorId);
                });

            migrationBuilder.CreateTable(
                name: "cenimas",
                columns: table => new
                {
                    cenimaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cenimas", x => x.cenimaId);
                });

            migrationBuilder.CreateTable(
                name: "producers",
                columns: table => new
                {
                    producerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producers", x => x.producerId);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    imageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    endDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movieCategory = table.Column<int>(type: "int", nullable: false),
                    cenimaId = table.Column<int>(type: "int", nullable: false),
                    producerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_movies_cenimas_cenimaId",
                        column: x => x.cenimaId,
                        principalTable: "cenimas",
                        principalColumn: "cenimaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movies_producers_producerId",
                        column: x => x.producerId,
                        principalTable: "producers",
                        principalColumn: "producerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "actors_movies",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false),
                    actorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors_movies", x => new { x.actorId, x.movieId });
                    table.ForeignKey(
                        name: "FK_actors_movies_actors_actorId",
                        column: x => x.actorId,
                        principalTable: "actors",
                        principalColumn: "actorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_actors_movies_movies_movieId",
                        column: x => x.movieId,
                        principalTable: "movies",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_actors_movies_movieId",
                table: "actors_movies",
                column: "movieId");

            migrationBuilder.CreateIndex(
                name: "IX_movies_cenimaId",
                table: "movies",
                column: "cenimaId");

            migrationBuilder.CreateIndex(
                name: "IX_movies_producerId",
                table: "movies",
                column: "producerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actors_movies");

            migrationBuilder.DropTable(
                name: "actors");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "cenimas");

            migrationBuilder.DropTable(
                name: "producers");
        }
    }
}
