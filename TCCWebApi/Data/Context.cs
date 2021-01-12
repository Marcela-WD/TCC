using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TCCWebApi.Models;

namespace TCCWebApi.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opcoes) : base(opcoes) { }

        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<IngredienteProduto> IngredienteProduto { get; set; }
        public DbSet<ModoPreparo> ModoPreparo { get; set; }
        public DbSet<ModoPreparoItem> ModoPreparoItem { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ingrediente>()
                .HasData(
                    new List<Ingrediente>()
                    {
                        new Ingrediente(1, "Trigo", "Gr"),
                        new Ingrediente(2, "Ovo", "Un"),
                        new Ingrediente(3, "Óleo", "Ml"),
                        new Ingrediente(4, "Açúcar", "Gr"),
                        new Ingrediente(5, "Água", "Ml"),
                        new Ingrediente(6, "Fermanto", "Gr"),
                        new Ingrediente(7, "Cenoura", "Un"),
                        new Ingrediente(8, "Leite", "Ml"),
                        new Ingrediente(9, "Achocolatado", "Gr"),
                        new Ingrediente(10, "Margarina", "Gr"),
                        new Ingrediente(11, "Leite Condensado", "Ml")
                    }
                );
            builder.Entity<ModoPreparo>()
                .HasData(
                    new List<ModoPreparo>()
                    {
                        new ModoPreparo(1, "Produção do Bolo de Cenoura"),
                        new ModoPreparo(2, "Produção da Nega Maluca"),
                        new ModoPreparo(3, "Produção Massa de Brigadeiro"),
                        new ModoPreparo(4, "Produção Massa Base para Bolos"),
                        new ModoPreparo(5, "Produção do Bolo Inglês")
                    }
                );

            builder.Entity<ModoPreparoItem>()
                .HasData(
                    new List<ModoPreparoItem>()
                    {
                        new ModoPreparoItem(1, "Colocar as cenouras, ovos, óleo e o açucar no liquidifador e bater até não sobrar pedaços de cenoura", 1, 1),
                        new ModoPreparoItem(2, "Em uma bacia, peneirar os itens batidos no liquidificador", 2, 1),
                        new ModoPreparoItem(3, "Acrescentar trigo e o fermento, misturar delicadamente até formar uma massa homogênea", 3, 1),
                        new ModoPreparoItem(4, "Despejar em uma forma e colocar para assar", 4, 1),
                        new ModoPreparoItem(5, "Bater claras em neve e deixar separado", 1, 2),
                        new ModoPreparoItem(6, "Bater as gemas com açúcar", 2, 2),
                        new ModoPreparoItem(7, "Acrescentqar o óleo e a água e misturar", 3, 2),
                        new ModoPreparoItem(8, "Acrescentar o trigo e o achocolatado e misturar", 4, 2),
                        new ModoPreparoItem(9, "Colocar o fermento e mexer delicadamente", 5, 2),
                        new ModoPreparoItem(10, "Por último acrescentar as claras em neve", 6, 2),
                        new ModoPreparoItem(11, "Despejar em uma forma e colocar para assar", 7, 2),
                        new ModoPreparoItem(12, "Em uma panela, colocar a margarina, o leite condensado e o achocolatado", 1, 3),
                        new ModoPreparoItem(13, "Cozinhar até conseguir ver o fundo da panela", 2, 3),
                        new ModoPreparoItem(14, "Colocar em um prato para a massa descansar", 3, 3),
                        new ModoPreparoItem(15, "Bater claras em neve e deixar separado", 1, 4),
                        new ModoPreparoItem(16, "Bater as gemas com o açúcar e a margarina", 2, 4),
                        new ModoPreparoItem(17, "Peneirar o trigo", 3, 4),
                        new ModoPreparoItem(18, "Acrescentar o trigo e o leite aos poucos", 4, 4),
                        new ModoPreparoItem(19, "Colocar o fermento e mexer delicadamente", 5, 4),
                        new ModoPreparoItem(20, "Por último acrescentar as claras em neve", 6, 4),
                        new ModoPreparoItem(21, "Despejar em duas formas e colocar para assar", 7, 4),
                        new ModoPreparoItem(22, "Em uma bacia, misturar o açúcar e a margarina", 1, 5),
                        new ModoPreparoItem(23, "Acrescentar os ovos e misturar", 2, 5),
                        new ModoPreparoItem(24, "Acrescentar o trigo e o leite aos poucos", 3, 5),
                        new ModoPreparoItem(25, "Colocar o fermento e mexer delicadamente", 4, 5),
                        new ModoPreparoItem(26, "Despejar em uma assadeira 3/4 da massa", 5, 5),
                        new ModoPreparoItem(27, "No restante da massa, colocar o achocolatado, misturar e colocar sobre a massa que está na assadeira", 6, 5),
                        new ModoPreparoItem(28, "Despejar em uma forma e colocar para assar", 7, 5)

                    }
                );

            builder.Entity<Produto>()
               .HasData(
                   new List<Produto>()
                   {
                        new Produto(1, "Bolo de cenoura", 1),
                        new Produto(2, "Nega maluca", 2),
                        new Produto(3, "Brigadeiro", 3),
                        new Produto(4, "Massa base para bolos", 4),
                        new Produto(5, "Bolo inglês", 5)
                   }
               );

            builder.Entity<IngredienteProduto>()
                .HasData(
                    new List<IngredienteProduto>()
                    {
                        new IngredienteProduto(1, 1, 1, 220),
                        new IngredienteProduto(2, 1, 2, 4),
                        new IngredienteProduto(3, 1, 3, 120),
                        new IngredienteProduto(4, 1, 4, 150),
                        new IngredienteProduto(5, 1, 6, 12),
                        new IngredienteProduto(6, 2, 2, 4),
                        new IngredienteProduto(7, 2, 4, 300),
                        new IngredienteProduto(8, 2, 5, 120),
                        new IngredienteProduto(9, 2, 3, 120),
                        new IngredienteProduto(10, 2, 1, 275),
                        new IngredienteProduto(11, 2, 9, 100),
                        new IngredienteProduto(12, 2, 6, 17),
                        new IngredienteProduto(13, 3, 10, 55),
                        new IngredienteProduto(14, 3, 9, 30),
                        new IngredienteProduto(15, 3, 11, 395),
                        new IngredienteProduto(16, 4, 10, 150),
                        new IngredienteProduto(17, 4, 4, 250),
                        new IngredienteProduto(18, 4, 2, 6),
                        new IngredienteProduto(19, 4, 1, 300),
                        new IngredienteProduto(20, 4, 8, 130),
                        new IngredienteProduto(21, 4, 6, 10),
                        new IngredienteProduto(22, 5, 4, 300),
                        new IngredienteProduto(23, 5, 10, 40),
                        new IngredienteProduto(24, 5, 2, 3),
                        new IngredienteProduto(25, 5, 1, 330),
                        new IngredienteProduto(26, 5, 8, 100),
                        new IngredienteProduto(27, 5, 6, 10),
                        new IngredienteProduto(28, 5, 9, 30)
                    }
                );
        }
    }
}