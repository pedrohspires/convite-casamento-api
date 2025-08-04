using System.ComponentModel.DataAnnotations.Schema;

namespace convite_casamento_api.Entities
{
    [Table("convidado")]
    public class Convidado : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("confirmado")]
        public bool Confirmado { get; set; } = false;

        [Column("ativo")]
        public bool Ativo { get; set; } = true;
    }
}
