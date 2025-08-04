using convite_casamento_api.DTOs.Convidado;
using convite_casamento_api.Entities;
using convite_casamento_api.Repositories.Interfaces;

namespace convite_casamento_api.Repositories.Implementations
{
    public class ConvidadoRepository : IConvidadoRepository
    {
        public readonly MyDbContext _dbContext;

        public ConvidadoRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateConvidadoAsync(ConvidadoCadastroDTO dto)
        {
            VerificaDados(dto);

            var novoConvidado = new Convidado();
            novoConvidado.Nome = dto.Nome;
            novoConvidado.Confirmado = dto.Confirmado;
            novoConvidado.Ativo = true;
            novoConvidado.DataCadastro = DateTime.UtcNow;

            await _dbContext.Convidado.AddAsync(novoConvidado);
            await _dbContext.SaveChangesAsync();

            return novoConvidado.Id;
        }

        private static void VerificaDados(ConvidadoCadastroDTO dto)
        {
            if (dto == null)
                throw new ArgumentNullException("Informe os dados do Convidado!");

            if (string.IsNullOrWhiteSpace(dto.Nome))
                throw new Exception("Preencha o campo 'Nome'!");
        }
    }
}
