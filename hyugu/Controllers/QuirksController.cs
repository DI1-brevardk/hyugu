using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using hyugu.Models;
using hyugu.Services;

namespace hyugu.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class QuirksController : ControllerBase
    {
        private readonly IQuirkService _quirkService; 

        public QuirksController(IQuirkService quirkService)
        {
            _quirkService = quirkService;
        }

        #region GET
        [HttpGet("")]
        public async Task<ActionResult<List<Quirk>>> GetAllQuirks()
        {
            return await _quirkService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Quirk>> GetOneQuirk(int id)
        {
            var quirk = await _quirkService.GetOne(id);

            if (quirk is null) return BadRequest("Quirk not found");
            else return Ok(quirk);
        }
        #endregion

        
        #region POST
        [HttpPost]
        public async Task<ActionResult<List<Quirk>>> CreateQuirk(Quirk newQuirk)
        {
            var quirks = await _quirkService.Create(newQuirk);

            if (quirks is null) return BadRequest("Error when generating the quirk");
            else return Ok(quirks);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> UpdateQuirk(Quirk quirkUpdate)
        {
            var quirk = await _quirkService.Update(quirkUpdate);

            if (!quirk) return BadRequest("Error when updating the quirk");
            else return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<bool>> DeleteQuirk(int id)
        {
            var quirk = await _quirkService.Delete(id);

            if (!quirk) return BadRequest("Error when deleting the quirk");
            else return Ok();
        }

        #endregion

    }
}
