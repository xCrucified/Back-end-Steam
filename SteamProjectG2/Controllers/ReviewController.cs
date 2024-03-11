using business_logic.DTOs;
using business_logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SteamProjectG2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly IReviewService reviewService;
        public ReviewController(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        } 

        [HttpGet("all")]
        public async Task<IActionResult> Get() => Ok(await reviewService.GetAll());
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id) => Ok(await reviewService.Get(id));

        [HttpPost]
        public IActionResult Create([FromForm] CreateEditionModel model)
        {
            reviewService.Create(model);
            return Ok();
        }


        [HttpPut]
        public IActionResult Edit([FromBody] EditionDto model)
        {
            reviewService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            reviewService.Delete(id);
            return Ok();
        }
    }
}
