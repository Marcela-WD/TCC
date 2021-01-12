using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCCWebApi.Models
{
    public class Ingrediente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(70)")]
        [Required]
        public string Descricao { get; set; }

        [Column(TypeName = "varchar(15)")]
        [Required]
        public string UnidadeMedida { get; set; }
        public IEnumerable<IngredienteProduto> IngredientesProdutos { get; set; }

        public Ingrediente(int id, string descricao, string unidadeMedida)
        {
            this.Id = id;
            this.UnidadeMedida = unidadeMedida;
            this.Descricao = descricao;
        }
        public Ingrediente() {}
    }
}