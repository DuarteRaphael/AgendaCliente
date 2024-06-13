using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaCliente.Service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendasClientesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Cadastrar()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Editar()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Apagar()
        {
            return Ok();
        }
        [HttpGet("page/limit")]
        public IActionResult BuscarTodos(int page, int limit)
        {
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult BuscarPorId(Guid id)
        {
            return Ok();
        }
    }
}
