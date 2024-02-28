using business_logic.DTOs;
using business_logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SteamProjectG2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditionController : ControllerBase
    {
        private readonly IEditionsService editionsService;
        public EditionController(IEditionsService editionsService)
        {
            this.editionsService = editionsService;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            return Ok(editionsService.GetAll());
        }
        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(editionsService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] CreateEditionModel model)
        {
            editionsService.Create(model);
            return Ok();
        }


        [HttpPut]
        public IActionResult Edit([FromBody] EditionDto model)
        {
            editionsService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            editionsService.Delete(id);
            return Ok();
        }
        
    }
}
