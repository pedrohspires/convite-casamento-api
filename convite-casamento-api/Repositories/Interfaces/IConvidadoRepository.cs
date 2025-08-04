using convite_casamento_api.DTOs.Convidado;

namespace convite_casamento_api.Repositories.Interfaces
{
    public interface IConvidadoRepository
    {
        public Task<int> CreateConvidadoAsync(ConvidadoCadastroDTO dto);
    }
}
