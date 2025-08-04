using convite_casamento_api.DTOs.Convidado;
using convite_casamento_api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace convite_casamento_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvidadoController : ControllerBase
    {
        public readonly MyDbContext _dbContext;
        public readonly IConvidadoRepository _convidadoRepository;

        public ConvidadoController(MyDbContext dbContext, IConvidadoRepository convidadoRepository)
        {
            _dbContext = dbContext;
            _convidadoRepository = convidadoRepository;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] ConvidadoCadastroDTO dto)
        {
            try
            {
                var resultado = await _convidadoRepository.CreateConvidadoAsync(dto);
                return Ok(resultado);
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }
    }
}
