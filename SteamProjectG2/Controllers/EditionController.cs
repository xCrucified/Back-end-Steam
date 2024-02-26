using Microsoft.AspNetCore.Mvc;

namespace SteamProjectG2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditionController : Controller
    {
        private readonly IProductsService productsService;
        public EditionController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            //return Ok(productsService.GetAll());
        }
        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            //return Ok(productsService.Get(id));
        }

        [HttpPost]
        public IActionResult Create(/*[FromForm] CreateProductModel model*/)
        {
            //productsService.Create(model);
            return Ok();
        }


        [HttpPut]
        public IActionResult Edit(/*[FromBody] ProductDto model*/)
        {
            //productsService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            //productsService.Delete(id);
            return Ok();
        }
        
    }
}
