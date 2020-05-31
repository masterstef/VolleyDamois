using Microsoft.EntityFrameworkCore.Migrations;

namespace VolleyDamois.Migrations
{
    public partial class ThePoulesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Sex_SexId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Categories_CategoryId",
                table: "Team");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Team",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Pouleid",
                table: "Team",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SexId",
                table: "Player",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Poules",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poules", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Team_Pouleid",
                table: "Team",
                column: "Pouleid");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Sex_SexId",
                table: "Player",
                column: "SexId",
                principalTable: "Sex",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Categories_CategoryId",
                table: "Team",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Poules_Pouleid",
                table: "Team",
                column: "Pouleid",
                principalTable: "Poules",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Sex_SexId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Categories_CategoryId",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Poules_Pouleid",
                table: "Team");

            migrationBuilder.DropTable(
                name: "Poules");

            migrationBuilder.DropIndex(
                name: "IX_Team_Pouleid",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Pouleid",
                table: "Team");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Team",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SexId",
                table: "Player",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Sex_SexId",
                table: "Player",
                column: "SexId",
                principalTable: "Sex",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Categories_CategoryId",
                table: "Team",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
