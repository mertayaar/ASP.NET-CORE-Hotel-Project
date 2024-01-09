using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migcontactreceiverd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Receiver",
                table: "Contacts",
                newName: "SenderName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "SenderMail");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Contacts",
                newName: "ReceiverName");

            migrationBuilder.AddColumn<string>(
                name: "ReceiverMail",
                table: "Contacts",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverMail",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "SenderName",
                table: "Contacts",
                newName: "Receiver");

            migrationBuilder.RenameColumn(
                name: "SenderMail",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ReceiverName",
                table: "Contacts",
                newName: "Mail");
        }
    }
}
