using System.ComponentModel.DataAnnotations.Schema;

namespace convite_casamento_api.Entities
{
    [Table("acompanhante_convidado")]
    public class ConvidadoAcompanhante : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("confirmado")]
        public bool Confirmado { get; set; } = true;

        [Column("ativo")]
        public bool Ativo { get; set; } = true;

        [Column("id_convidado")]
        public int ConvidadoId { get; set; }
        public Convidado? Convidado { get; set; }
    }
}
