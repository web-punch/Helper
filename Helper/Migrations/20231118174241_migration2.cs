using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Helper.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkTitles_WorkTypeId",
                table: "WorkTitles");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "WorkTitles",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "WorkTitles",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_WorkTitles_WorkTypeId_Name_Unit",
                table: "WorkTitles",
                columns: new[] { "WorkTypeId", "Name", "Unit" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_WorkTitles_WorkTypeId_Name_Unit",
                table: "WorkTitles");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "WorkTitles",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "WorkTitles",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTitles_WorkTypeId",
                table: "WorkTitles",
                column: "WorkTypeId");
        }
    }
}
