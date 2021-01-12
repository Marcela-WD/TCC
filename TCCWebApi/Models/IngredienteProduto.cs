using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCCWebApi.Models
{
    public class IngredienteProduto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        [ForeignKey("Ingrediente")]
        public int IngredienteId { get; set; }
        public Ingrediente Ingrediente { get; set; }

        [Required]
        public int Quantidade { get; set; }
        
        public IngredienteProduto(int id, int produtoId, int ingredienteId, int quantidade)
        {
            this.Id = id;
            this.ProdutoId = produtoId;
            this.IngredienteId = ingredienteId;
            this.Quantidade = quantidade;

        }
    }
}