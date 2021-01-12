using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCWebApi.Migrations
{
    public partial class AjusteFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "UnidadeMedida" },
                values: new object[] { "Trigo", "Gr" });

            migrationBuilder.UpdateData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descricao", "UnidadeMedida" },
                values: new object[] { "Ovo", "Un" });

            migrationBuilder.UpdateData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descricao", "UnidadeMedida" },
                values: new object[] { "Óleo", "Ml" });

            migrationBuilder.InsertData(
                table: "Ingrediente",
                columns: new[] { "Id", "Descricao", "UnidadeMedida" },
                values: new object[,]
                {
                    { 11, "Leite Condensado", "Ml" },
                    { 10, "Margarina", "Gr" },
                    { 4, "Açúcar", "Gr" },
                    { 8, "Leite", "Ml" },
                    { 7, "Cenoura", "Un" },
                    { 9, "Achocolatado", "Gr" },
                    { 5, "Água", "Ml" },
                    { 6, "Fermanto", "Gr" }
                });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantidade",
                value: 220);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantidade",
                value: 4);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantidade",
                value: 120);

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IngredienteId", "Quantidade" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProdutoId", "Quantidade" },
                values: new object[] { 2, 120 });

            migrationBuilder.InsertData(
                table: "IngredienteProduto",
                columns: new[] { "Id", "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 10, 1, 2, 275 });

            migrationBuilder.UpdateData(
                table: "ModoPreparo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Produção do Bolo de Cenoura");

            migrationBuilder.UpdateData(
                table: "ModoPreparo",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descricao",
                value: "Produção da Nega Maluca");

            migrationBuilder.UpdateData(
                table: "ModoPreparo",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descricao",
                value: "Produção Massa de Brigadeiro");

            migrationBuilder.InsertData(
                table: "ModoPreparo",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 5, "Produção do Bolo Inglês" },
                    { 4, "Produção Massa Base para Bolos" }
                });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Colocar as cenouras, ovos, óleo e o açucar no liquidifador e bater até não sobrar pedaços de cenoura");

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descricao",
                value: "Em uma bacia, peneirar os itens batidos no liquidificador");

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descricao",
                value: "Acrescentar trigo e o fermento, misturar delicadamente até formar uma massa homogênea");

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[] { "Despejar em uma forma e colocar para assar", 1, 4 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Descricao", "Sequencia" },
                values: new object[] { "Bater claras em neve e deixar separado", 1 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Descricao", "Sequencia" },
                values: new object[] { "Bater as gemas com açúcar", 2 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[] { "Acrescentqar o óleo e a água e misturar", 2, 3 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[] { "Acrescentar o trigo e o achocolatado e misturar", 2, 4 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[] { "Colocar o fermento e mexer delicadamente", 2, 5 });

            migrationBuilder.InsertData(
                table: "ModoPreparoItem",
                columns: new[] { "Id", "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[,]
                {
                    { 13, "Cozinhar até conseguir ver o fundo da panela", 3, 2 },
                    { 10, "Por último acrescentar as claras em neve", 2, 6 },
                    { 11, "Despejar em uma forma e colocar para assar", 2, 7 },
                    { 14, "Colocar em um prato para a massa descansar", 3, 3 },
                    { 12, "Em uma panela, colocar a margarina, o leite condensado e o achocolatado", 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Bolo de cenoura");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descricao",
                value: "Nega maluca");

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 4, 1, 150 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 6, 1, 12 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 4, 2, 300 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 5, 2, 120 });

            migrationBuilder.InsertData(
                table: "IngredienteProduto",
                columns: new[] { "Id", "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[,]
                {
                    { 12, 6, 2, 17 },
                    { 11, 9, 2, 100 },
                    { 14, 9, 3, 30 },
                    { 13, 10, 3, 55 },
                    { 15, 11, 3, 395 }
                });

            migrationBuilder.InsertData(
                table: "ModoPreparoItem",
                columns: new[] { "Id", "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[,]
                {
                    { 27, "No restante da massa, colocar o achocolatado, misturar e colocar sobre a massa que está na assadeira", 5, 6 },
                    { 26, "Despejar em uma assadeira 3/4 da massa", 5, 5 },
                    { 25, "Colocar o fermento e mexer delicadamente", 5, 4 },
                    { 24, "Acrescentar o trigo e o leite aos poucos", 5, 3 },
                    { 23, "Acrescentar os ovos e misturar", 5, 2 },
                    { 22, "Em uma bacia, misturar o açúcar e a margarina", 5, 1 },
                    { 18, "Acrescentar o trigo e o leite aos poucos", 4, 4 },
                    { 20, "Por último acrescentar as claras em neve", 4, 6 },
                    { 19, "Colocar o fermento e mexer delicadamente", 4, 5 },
                    { 28, "Despejar em uma forma e colocar para assar", 5, 7 },
                    { 17, "Peneirar o trigo", 4, 3 },
                    { 16, "Bater as gemas com o açúcar e a margarina", 4, 2 },
                    { 15, "Bater claras em neve e deixar separado", 4, 1 },
                    { 21, "Despejar em duas formas e colocar para assar", 4, 7 }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "ModoPreparoId" },
                values: new object[,]
                {
                    { 4, "Massa base para bolos", 4 },
                    { 5, "Bolo inglês", 5 }
                });

            migrationBuilder.InsertData(
                table: "IngredienteProduto",
                columns: new[] { "Id", "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[,]
                {
                    { 16, 10, 4, 150 },
                    { 17, 4, 4, 250 },
                    { 18, 2, 4, 6 },
                    { 19, 1, 4, 300 },
                    { 20, 8, 4, 130 },
                    { 21, 6, 4, 10 },
                    { 22, 4, 5, 300 },
                    { 23, 10, 5, 40 },
                    { 24, 2, 5, 3 },
                    { 25, 1, 5, 330 },
                    { 26, 8, 5, 100 },
                    { 27, 6, 5, 10 },
                    { 28, 9, 5, 30 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ModoPreparo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ModoPreparo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "UnidadeMedida" },
                values: new object[] { "Nescao", "Gramas" });

            migrationBuilder.UpdateData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descricao", "UnidadeMedida" },
                values: new object[] { "Azeite", "Mililitros" });

            migrationBuilder.UpdateData(
                table: "Ingrediente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descricao", "UnidadeMedida" },
                values: new object[] { "Ovo", "Unidade" });

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
                columns: new[] { "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 1, 2, 200 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 2, 2, 80 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IngredienteId", "Quantidade" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 1, 3, 200 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[] { 2, 3, 80 });

            migrationBuilder.UpdateData(
                table: "IngredienteProduto",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProdutoId", "Quantidade" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "ModoPreparo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Preparar nega maluca");

            migrationBuilder.UpdateData(
                table: "ModoPreparo",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descricao",
                value: "Preparar bolo de cenoura");

            migrationBuilder.UpdateData(
                table: "ModoPreparo",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descricao",
                value: "Preparar Brigadeiro");

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Colocar nescau");

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descricao",
                value: "Colocar açucar");

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descricao",
                value: "Colocar azeite");

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[] { "Colocar cenoura", 2, 1 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Descricao", "Sequencia" },
                values: new object[] { "Colocar trigo", 2 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Descricao", "Sequencia" },
                values: new object[] { "Colocar azeite", 3 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[] { "Colocar leite condesado", 3, 1 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[] { "Colocar nescau", 3, 2 });

            migrationBuilder.UpdateData(
                table: "ModoPreparoItem",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[] { "Colocar margarina", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Nega maluca");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descricao",
                value: "Bolo cenoura");
        }
    }
}
