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
        public IActionResult Post()
        {
            return Ok("Deu certo");
        }

        //PUT api/Users
        [HttpPut("{id}/profile-picture")]
        public IActionResult PutProfilePicture(IFormFile file)
        {
            var description = $"File: {file.FileName}  Size: {file.Length}";
            return Ok(description);
        }
    }
}
