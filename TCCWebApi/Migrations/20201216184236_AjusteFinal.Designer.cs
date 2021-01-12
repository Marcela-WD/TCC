﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCCWebApi.Data;

namespace TCCWebApi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201216184236_AjusteFinal")]
    partial class AjusteFinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TCCWebApi.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<string>("UnidadeMedida")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Ingrediente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Trigo",
                            UnidadeMedida = "Gr"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Ovo",
                            UnidadeMedida = "Un"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Óleo",
                            UnidadeMedida = "Ml"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Açúcar",
                            UnidadeMedida = "Gr"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Água",
                            UnidadeMedida = "Ml"
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "Fermanto",
                            UnidadeMedida = "Gr"
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "Cenoura",
                            UnidadeMedida = "Un"
                        },
                        new
                        {
                            Id = 8,
                            Descricao = "Leite",
                            UnidadeMedida = "Ml"
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "Achocolatado",
                            UnidadeMedida = "Gr"
                        },
                        new
                        {
                            Id = 10,
                            Descricao = "Margarina",
                            UnidadeMedida = "Gr"
                        },
                        new
                        {
                            Id = 11,
                            Descricao = "Leite Condensado",
                            UnidadeMedida = "Ml"
                        });
                });

            modelBuilder.Entity("TCCWebApi.Models.IngredienteProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IngredienteId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredienteId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("IngredienteProduto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IngredienteId = 1,
                            ProdutoId = 1,
                            Quantidade = 220
                        },
                        new
                        {
                            Id = 2,
                            IngredienteId = 2,
                            ProdutoId = 1,
                            Quantidade = 4
                        },
                        new
                        {
                            Id = 3,
                            IngredienteId = 3,
                            ProdutoId = 1,
                            Quantidade = 120
                        },
                        new
                        {
                            Id = 4,
                            IngredienteId = 4,
                            ProdutoId = 1,
                            Quantidade = 150
                        },
                        new
                        {
                            Id = 5,
                            IngredienteId = 6,
                            ProdutoId = 1,
                            Quantidade = 12
                        },
                        new
                        {
                            Id = 6,
                            IngredienteId = 2,
                            ProdutoId = 2,
                            Quantidade = 4
                        },
                        new
                        {
                            Id = 7,
                            IngredienteId = 4,
                            ProdutoId = 2,
                            Quantidade = 300
                        },
                        new
                        {
                            Id = 8,
                            IngredienteId = 5,
                            ProdutoId = 2,
                            Quantidade = 120
                        },
                        new
                        {
                            Id = 9,
                            IngredienteId = 3,
                            ProdutoId = 2,
                            Quantidade = 120
                        },
                        new
                        {
                            Id = 10,
                            IngredienteId = 1,
                            ProdutoId = 2,
                            Quantidade = 275
                        },
                        new
                        {
                            Id = 11,
                            IngredienteId = 9,
                            ProdutoId = 2,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 12,
                            IngredienteId = 6,
                            ProdutoId = 2,
                            Quantidade = 17
                        },
                        new
                        {
                            Id = 13,
                            IngredienteId = 10,
                            ProdutoId = 3,
                            Quantidade = 55
                        },
                        new
                        {
                            Id = 14,
                            IngredienteId = 9,
                            ProdutoId = 3,
                            Quantidade = 30
                        },
                        new
                        {
                            Id = 15,
                            IngredienteId = 11,
                            ProdutoId = 3,
                            Quantidade = 395
                        },
                        new
                        {
                            Id = 16,
                            IngredienteId = 10,
                            ProdutoId = 4,
                            Quantidade = 150
                        },
                        new
                        {
                            Id = 17,
                            IngredienteId = 4,
                            ProdutoId = 4,
                            Quantidade = 250
                        },
                        new
                        {
                            Id = 18,
                            IngredienteId = 2,
                            ProdutoId = 4,
                            Quantidade = 6
                        },
                        new
                        {
                            Id = 19,
                            IngredienteId = 1,
                            ProdutoId = 4,
                            Quantidade = 300
                        },
                        new
                        {
                            Id = 20,
                            IngredienteId = 8,
                            ProdutoId = 4,
                            Quantidade = 130
                        },
                        new
                        {
                            Id = 21,
                            IngredienteId = 6,
                            ProdutoId = 4,
                            Quantidade = 10
                        },
                        new
                        {
                            Id = 22,
                            IngredienteId = 4,
                            ProdutoId = 5,
                            Quantidade = 300
                        },
                        new
                        {
                            Id = 23,
                            IngredienteId = 10,
                            ProdutoId = 5,
                            Quantidade = 40
                        },
                        new
                        {
                            Id = 24,
                            IngredienteId = 2,
                            ProdutoId = 5,
                            Quantidade = 3
                        },
                        new
                        {
                            Id = 25,
                            IngredienteId = 1,
                            ProdutoId = 5,
                            Quantidade = 330
                        },
                        new
                        {
                            Id = 26,
                            IngredienteId = 8,
                            ProdutoId = 5,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 27,
                            IngredienteId = 6,
                            ProdutoId = 5,
                            Quantidade = 10
                        },
                        new
                        {
                            Id = 28,
                            IngredienteId = 9,
                            ProdutoId = 5,
                            Quantidade = 30
                        });
                });

            modelBuilder.Entity("TCCWebApi.Models.ModoPreparo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ModoPreparo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Produção do Bolo de Cenoura"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Produção da Nega Maluca"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Produção Massa de Brigadeiro"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Produção Massa Base para Bolos"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Produção do Bolo Inglês"
                        });
                });

            modelBuilder.Entity("TCCWebApi.Models.ModoPreparoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("ModoPreparoId")
                        .HasColumnType("int");

                    b.Property<int>("Sequencia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModoPreparoId");

                    b.ToTable("ModoPreparoItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Colocar as cenouras, ovos, óleo e o açucar no liquidifador e bater até não sobrar pedaços de cenoura",
                            ModoPreparoId = 1,
                            Sequencia = 1
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Em uma bacia, peneirar os itens batidos no liquidificador",
                            ModoPreparoId = 1,
                            Sequencia = 2
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Acrescentar trigo e o fermento, misturar delicadamente até formar uma massa homogênea",
                            ModoPreparoId = 1,
                            Sequencia = 3
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Despejar em uma forma e colocar para assar",
                            ModoPreparoId = 1,
                            Sequencia = 4
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Bater claras em neve e deixar separado",
                            ModoPreparoId = 2,
                            Sequencia = 1
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "Bater as gemas com açúcar",
                            ModoPreparoId = 2,
                            Sequencia = 2
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "Acrescentqar o óleo e a água e misturar",
                            ModoPreparoId = 2,
                            Sequencia = 3
                        },
                        new
                        {
                            Id = 8,
                            Descricao = "Acrescentar o trigo e o achocolatado e misturar",
                            ModoPreparoId = 2,
                            Sequencia = 4
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "Colocar o fermento e mexer delicadamente",
                            ModoPreparoId = 2,
                            Sequencia = 5
                        },
                        new
                        {
                            Id = 10,
                            Descricao = "Por último acrescentar as claras em neve",
                            ModoPreparoId = 2,
                            Sequencia = 6
                        },
                        new
                        {
                            Id = 11,
                            Descricao = "Despejar em uma forma e colocar para assar",
                            ModoPreparoId = 2,
                            Sequencia = 7
                        },
                        new
                        {
                            Id = 12,
                            Descricao = "Em uma panela, colocar a margarina, o leite condensado e o achocolatado",
                            ModoPreparoId = 3,
                            Sequencia = 1
                        },
                        new
                        {
                            Id = 13,
                            Descricao = "Cozinhar até conseguir ver o fundo da panela",
                            ModoPreparoId = 3,
                            Sequencia = 2
                        },
                        new
                        {
                            Id = 14,
                            Descricao = "Colocar em um prato para a massa descansar",
                            ModoPreparoId = 3,
                            Sequencia = 3
                        },
                        new
                        {
                            Id = 15,
                            Descricao = "Bater claras em neve e deixar separado",
                            ModoPreparoId = 4,
                            Sequencia = 1
                        },
                        new
                        {
                            Id = 16,
                            Descricao = "Bater as gemas com o açúcar e a margarina",
                            ModoPreparoId = 4,
                            Sequencia = 2
                        },
                        new
                        {
                            Id = 17,
                            Descricao = "Peneirar o trigo",
                            ModoPreparoId = 4,
                            Sequencia = 3
                        },
                        new
                        {
                            Id = 18,
                            Descricao = "Acrescentar o trigo e o leite aos poucos",
                            ModoPreparoId = 4,
                            Sequencia = 4
                        },
                        new
                        {
                            Id = 19,
                            Descricao = "Colocar o fermento e mexer delicadamente",
                            ModoPreparoId = 4,
                            Sequencia = 5
                        },
                        new
                        {
                            Id = 20,
                            Descricao = "Por último acrescentar as claras em neve",
                            ModoPreparoId = 4,
                            Sequencia = 6
                        },
                        new
                        {
                            Id = 21,
                            Descricao = "Despejar em duas formas e colocar para assar",
                            ModoPreparoId = 4,
                            Sequencia = 7
                        },
                        new
                        {
                            Id = 22,
                            Descricao = "Em uma bacia, misturar o açúcar e a margarina",
                            ModoPreparoId = 5,
                            Sequencia = 1
                        },
                        new
                        {
                            Id = 23,
                            Descricao = "Acrescentar os ovos e misturar",
                            ModoPreparoId = 5,
                            Sequencia = 2
                        },
                        new
                        {
                            Id = 24,
                            Descricao = "Acrescentar o trigo e o leite aos poucos",
                            ModoPreparoId = 5,
                            Sequencia = 3
                        },
                        new
                        {
                            Id = 25,
                            Descricao = "Colocar o fermento e mexer delicadamente",
                            ModoPreparoId = 5,
                            Sequencia = 4
                        },
                        new
                        {
                            Id = 26,
                            Descricao = "Despejar em uma assadeira 3/4 da massa",
                            ModoPreparoId = 5,
                            Sequencia = 5
                        },
                        new
                        {
                            Id = 27,
                            Descricao = "No restante da massa, colocar o achocolatado, misturar e colocar sobre a massa que está na assadeira",
                            ModoPreparoId = 5,
                            Sequencia = 6
                        },
                        new
                        {
                            Id = 28,
                            Descricao = "Despejar em uma forma e colocar para assar",
                            ModoPreparoId = 5,
                            Sequencia = 7
                        });
                });

            modelBuilder.Entity("TCCWebApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<int>("ModoPreparoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModoPreparoId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Bolo de cenoura",
                            ModoPreparoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Nega maluca",
                            ModoPreparoId = 2
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Brigadeiro",
                            ModoPreparoId = 3
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Massa base para bolos",
                            ModoPreparoId = 4
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Bolo inglês",
                            ModoPreparoId = 5
                        });
                });

            modelBuilder.Entity("TCCWebApi.Models.IngredienteProduto", b =>
                {
                    b.HasOne("TCCWebApi.Models.Ingrediente", "Ingrediente")
                        .WithMany("IngredientesProdutos")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCCWebApi.Models.Produto", "Produto")
                        .WithMany("IngredientesProdutos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrediente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("TCCWebApi.Models.ModoPreparoItem", b =>
                {
                    b.HasOne("TCCWebApi.Models.ModoPreparo", "ModoPreparo")
                        .WithMany("ModoPreparoItems")
                        .HasForeignKey("ModoPreparoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModoPreparo");
                });

            modelBuilder.Entity("TCCWebApi.Models.Produto", b =>
                {
                    b.HasOne("TCCWebApi.Models.ModoPreparo", "ModoPreparo")
                        .WithMany("Produtos")
                        .HasForeignKey("ModoPreparoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModoPreparo");
                });

            modelBuilder.Entity("TCCWebApi.Models.Ingrediente", b =>
                {
                    b.Navigation("IngredientesProdutos");
                });

            modelBuilder.Entity("TCCWebApi.Models.ModoPreparo", b =>
                {
                    b.Navigation("ModoPreparoItems");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("TCCWebApi.Models.Produto", b =>
                {
                    b.Navigation("IngredientesProdutos");
                });
#pragma warning restore 612, 618
        }
    }
}
