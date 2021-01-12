using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TCCWebApi.Models
{
    public class ModoPreparo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Descricao { get; set; }
        public IEnumerable<ModoPreparoItem> ModoPreparoItems { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }

        public ModoPreparo(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;

        }
    }
}