using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Access_Service.Migrations
{
    /// <inheritdoc />
  public partial class SeedInitialUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var email = "jane.doe@example.com";
            var password = "hashed_password_123";
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            var userUuid = 1;

            migrationBuilder.Sql($@"
                INSERT INTO Users (Email, Password, UserUuid)
                VALUES ('{email}', '{hashedPassword}', '{userUuid}')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var email = "jane.doe@example.com";

            migrationBuilder.Sql($@"
                DELETE FROM Users
                WHERE Email = '{email}'
            ");
        }
    }
}
