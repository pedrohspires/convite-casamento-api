namespace convite_casamento_api.DTOs.Convidado
{
    public class ConvidadoCadastroDTO
    {
        public string Nome { get; set; } = string.Empty;
        public bool Confirmado { get; set; } = false;
        public bool Ativo { get; set; } = true;
    }
}
