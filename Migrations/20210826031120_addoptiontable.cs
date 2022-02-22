using Microsoft.EntityFrameworkCore.Migrations;

namespace catering.Migrations
{
    public partial class addoptiontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_properties_category_categoryId",
                table: "properties");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "properties",
                newName: "optionId");

            migrationBuilder.RenameIndex(
                name: "IX_properties_categoryId",
                table: "properties",
                newName: "IX_properties_optionId");

            migrationBuilder.CreateTable(
                name: "option",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_option_category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_option_categoryId",
                table: "option",
                column: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_properties_option_optionId",
                table: "properties",
                column: "optionId",
                principalTable: "option",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_properties_option_optionId",
                table: "properties");

            migrationBuilder.DropTable(
                name: "option");

            migrationBuilder.RenameColumn(
                name: "optionId",
                table: "properties",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_properties_optionId",
                table: "properties",
                newName: "IX_properties_categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_properties_category_categoryId",
                table: "properties",
                column: "categoryId",
                principalTable: "category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
