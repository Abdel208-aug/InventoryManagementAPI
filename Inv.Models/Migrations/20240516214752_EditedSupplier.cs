using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inv.Models.Migrations
{
    /// <inheritdoc />
    public partial class EditedSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Supliers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Supliers",
                newName: "SupplierId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Supliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Supliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Supliers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Supliers");

            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Supliers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Supliers");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Supliers",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Supliers",
                newName: "CategoryId");
        }
    }
}
