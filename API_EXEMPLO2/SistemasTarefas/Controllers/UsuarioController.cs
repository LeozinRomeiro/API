using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemasTarefas.Models;

namespace SistemasTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet] public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios() {
            return Ok();
        }
    }
}
