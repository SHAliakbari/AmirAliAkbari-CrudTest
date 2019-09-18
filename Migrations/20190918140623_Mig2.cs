using Microsoft.EntityFrameworkCore.Migrations;

namespace AmirAliAkbariCrudTest.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "RegisterForm",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "RegisterForm",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "RegisterForm",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_RegisterForm_Email",
                schema: "dbo",
                table: "RegisterForm",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterForm_FirstName_LastName_DateOfBirth",
                schema: "dbo",
                table: "RegisterForm",
                columns: new[] { "FirstName", "LastName", "DateOfBirth" },
                unique: true,
                filter: "[FirstName] IS NOT NULL AND [LastName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_RegisterForm_Email",
                schema: "dbo",
                table: "RegisterForm");

            migrationBuilder.DropIndex(
                name: "IX_RegisterForm_FirstName_LastName_DateOfBirth",
                schema: "dbo",
                table: "RegisterForm");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "RegisterForm",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "RegisterForm",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "RegisterForm",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
