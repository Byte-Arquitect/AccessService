using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Access_Service.Migrations
{
    /// <inheritdoc />
    public partial class AddUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RevokedTokens",
                table: "RevokedTokens");

            migrationBuilder.RenameTable(
                name: "RevokedTokens",
                newName: "TokenBlacklist");

            migrationBuilder.RenameColumn(
                name: "Token",
                table: "TokenBlacklist",
                newName: "Jti");

            migrationBuilder.AddColumn<string>(
                name: "UserUuid",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokenBlacklist",
                table: "TokenBlacklist",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TokenBlacklist",
                table: "TokenBlacklist");

            migrationBuilder.DropColumn(
                name: "UserUuid",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "TokenBlacklist",
                newName: "RevokedTokens");

            migrationBuilder.RenameColumn(
                name: "Jti",
                table: "RevokedTokens",
                newName: "Token");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RevokedTokens",
                table: "RevokedTokens",
                column: "Id");
        }
    }
}
