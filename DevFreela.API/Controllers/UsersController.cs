using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //POST api/Users
        [HttpPost]
        public IActionResult Teste()
        {
            return Ok("Deu certo");
        }
    }
}
