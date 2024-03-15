using business_logic.DTOs;
using business_logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SteamProjectG2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get() => Ok(await categoryService.GetAll());
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id) => Ok(await categoryService.Get(id));

        [HttpPost]
        public IActionResult Create([FromForm] CreateCategoryModel model)
        {
            categoryService.Create(model);
            return Ok();
        }


        [HttpPut]
        public IActionResult Edit([FromBody] CategoryDto model)
        {
            categoryService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            categoryService.Delete(id);
            return Ok();
        }
    }
}
