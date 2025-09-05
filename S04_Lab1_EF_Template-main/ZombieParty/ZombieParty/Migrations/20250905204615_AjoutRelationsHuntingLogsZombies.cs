using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class AjoutRelationsHuntingLogsZombies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HuntingLogZombie",
                columns: table => new
                {
                    huntingLogsId = table.Column<int>(type: "int", nullable: false),
                    zombiesZombieTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntingLogZombie", x => new { x.huntingLogsId, x.zombiesZombieTypeId });
                    table.ForeignKey(
                        name: "FK_HuntingLogZombie_HuntingLogs_huntingLogsId",
                        column: x => x.huntingLogsId,
                        principalTable: "HuntingLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HuntingLogZombie_Zombies_zombiesZombieTypeId",
                        column: x => x.zombiesZombieTypeId,
                        principalTable: "Zombies",
                        principalColumn: "ZombieTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntingLogZombie_zombiesZombieTypeId",
                table: "HuntingLogZombie",
                column: "zombiesZombieTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HuntingLogZombie");
        }
    }
}
