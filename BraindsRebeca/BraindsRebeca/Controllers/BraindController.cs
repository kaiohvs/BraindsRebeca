using BraindsRebeca.Models;
using BraindsRebeca.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BraindsRebeca.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BraindController : ControllerBase
    {
        private readonly IBraindRepository _braindReposity;

        public BraindController(IBraindRepository braindRepository)
        {
            _braindReposity = braindRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Braind>> GetBrainds()
        {
            return await _braindReposity.Get();
        }

        [HttpGet("BuscarId/{id}")]
        public async Task<ActionResult<Braind>> GetBrainds(int id)
        {
            return await _braindReposity.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Braind>> Post([FromBody] Braind braind)
        {
            var newBraind = await _braindReposity.Creater(braind);
            return CreatedAtAction(nameof(GetBrainds), new { id = newBraind.Id}, newBraind);
                   
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var braindToDelete = await _braindReposity.Get(id);

            if(braindToDelete == null)
            {
               return NotFound();
            }
            else
            {
             await  _braindReposity.Delete(braindToDelete.Id);
                return NoContent();
            }
        }
        [HttpPut]
        public async Task<ActionResult> PutBrainds(int id, [FromBody]Braind braind)
        {
            if (id != braind.Id)
            {
                return BadRequest();
            }
            else
            {
                await _braindReposity.Update(braind);
                return NoContent();
            }
        }
    }
}
