using DevFreela.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly FreeLanceTotalCostConfig _config;
        public ProjectsController(IOptions<FreeLanceTotalCostConfig> options)
        {
            _config = options.Value;
        }
        //GET /api/Projects/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new Exception("Teste handler");
            return Ok();
        }
        //POST /api/Projects
        [HttpPost]
        public IActionResult Post(CreateProjectInputModel model)
        {
            if(model.TotalCost<_config.Minimum || model.TotalCost>_config.Maximum)
                return BadRequest("Número fora dos limites");
            return CreatedAtAction(nameof(GetById), new { id=1},model);
        }

        //PUT /api/Projects/1234
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectInputModel model)
        {
            return NoContent();
        }

        //DELETE /api/Projects/1234
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        //PUT api/Projects/1234/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //PUT api/Projects/1234/start
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }

        //POST api/Projects/1234/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateProjectCommentInputModel model)
        {
            return Ok();
        }

    }
}
