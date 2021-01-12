using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCCWebApi.Models
{
    public class ModoPreparoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(200)")]
        [Required]
        public string Descricao { get; set; }

        [Column]
        [Required]
        public int Sequencia { get; set; }

        [ForeignKey("ModoPreparo")]
        public int ModoPreparoId { get; set; }
        public ModoPreparo ModoPreparo { get; set; }

        public ModoPreparoItem(int id, string descricao, int sequencia, int modoPreparoId)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Sequencia = sequencia;
            this.ModoPreparoId = modoPreparoId;
        }
    }
}