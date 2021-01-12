using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCCWebApi.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(70)")]
        [Required]
        public string Descricao { get; set; }

        [ForeignKey("ModoPreparo")]
        public int ModoPreparoId { get; set; }
        public ModoPreparo ModoPreparo { get; set; }
        
        public IEnumerable<IngredienteProduto> IngredientesProdutos { get; set; }

        public Produto(int id, string descricao, int modoPreparoId)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.ModoPreparoId = modoPreparoId;

        }
    }
}