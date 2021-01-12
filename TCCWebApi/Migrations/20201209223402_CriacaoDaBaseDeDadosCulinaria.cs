using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCWebApi.Migrations
{
    public partial class CriacaoDaBaseDeDadosCulinaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(70)", nullable: false),
                    UnidadeMedida = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModoPreparo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModoPreparo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModoPreparoItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false),
                    Sequencia = table.Column<int>(type: "int", nullable: false),
                    ModoPreparoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModoPreparoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModoPreparoItem_ModoPreparo_ModoPreparoId",
                        column: x => x.ModoPreparoId,
                        principalTable: "ModoPreparo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(70)", nullable: false),
                    ModoPreparoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_ModoPreparo_ModoPreparoId",
                        column: x => x.ModoPreparoId,
                        principalTable: "ModoPreparo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredienteProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    IngredienteId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredienteProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredienteProduto_Ingrediente_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredienteProduto_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingrediente",
                columns: new[] { "Id", "Descricao", "UnidadeMedida" },
                values: new object[,]
                {
                    { 1, "Nescao", "Gramas" },
                    { 2, "Azeite", "Mililitros" },
                    { 3, "Ovo", "Unidade" }
                });

            migrationBuilder.InsertData(
                table: "ModoPreparo",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "Preparar nega maluca" },
                    { 2, "Preparar bolo de cenoura" },
                    { 3, "Preparar Brigadeiro" }
                });

            migrationBuilder.InsertData(
                table: "ModoPreparoItem",
                columns: new[] { "Id", "Descricao", "ModoPreparoId", "Sequencia" },
                values: new object[,]
                {
                    { 1, "Colocar nescau", 1, 1 },
                    { 2, "Colocar açucar", 1, 2 },
                    { 3, "Colocar azeite", 1, 3 },
                    { 4, "Colocar cenoura", 2, 1 },
                    { 5, "Colocar trigo", 2, 2 },
                    { 6, "Colocar azeite", 2, 3 },
                    { 7, "Colocar leite condesado", 3, 1 },
                    { 8, "Colocar nescau", 3, 2 },
                    { 9, "Colocar margarina", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "ModoPreparoId" },
                values: new object[,]
                {
                    { 1, "Nega maluca", 1 },
                    { 2, "Bolo cenoura", 2 },
                    { 3, "Brigadeiro", 3 }
                });

            migrationBuilder.InsertData(
                table: "IngredienteProduto",
                columns: new[] { "Id", "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, 1, 200m },
                    { 2, 2, 1, 80m },
                    { 3, 3, 1, 3m },
                    { 4, 1, 2, 200m },
                    { 5, 2, 2, 80m },
                    { 6, 3, 2, 3m },
                    { 7, 1, 3, 200m },
                    { 8, 2, 3, 80m },
                    { 9, 3, 3, 3m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredienteProduto_IngredienteId",
                table: "IngredienteProduto",
                column: "IngredienteId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredienteProduto_ProdutoId",
                table: "IngredienteProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModoPreparoItem_ModoPreparoId",
                table: "ModoPreparoItem",
                column: "ModoPreparoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ModoPreparoId",
                table: "Produto",
                column: "ModoPreparoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredienteProduto");

            migrationBuilder.DropTable(
                name: "ModoPreparoItem");

            migrationBuilder.DropTable(
                name: "Ingrediente");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "ModoPreparo");
        }
    }
}
