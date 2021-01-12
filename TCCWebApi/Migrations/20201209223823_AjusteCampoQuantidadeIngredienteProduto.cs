using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCWebApi.Migrations
{
    public partial class AjusteCampoQuantidadeIngredienteProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "IngredienteProduto",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantidade",
                value: 200);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantidade",
                value: 80);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantidade",
                value: 3);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantidade",
                value: 200);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantidade",
                value: 80);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantidade",
                value: 3);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantidade",
                value: 200);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantidade",
                value: 80);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantidade",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Quantidade",
                table: "IngredienteProduto",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantidade",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantidade",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantidade",
                value: 3m);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantidade",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantidade",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantidade",
                value: 3m);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantidade",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantidade",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantidade",
                value: 3m);
        }
    }
}
