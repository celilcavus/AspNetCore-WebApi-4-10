using CelilCavus.WebApi.Entites;
using CelilCavus.WebApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> _serivce;

        public CategoryController(IRepository<Category> serivce)
        {
            _serivce = serivce;
        }
        [HttpGet]
        public IActionResult GetCategory()
        {
            var values = _serivce.GetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _serivce.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult PostCategory(Category category)
        {

            if (category is not null)
            {
                _serivce.Add(category);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);

        }
        [HttpPut]
        public IActionResult PutCategory(Category category)
        {
            if (category is not null)
            {
                _serivce.Update(category);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
        [HttpDelete]
        public IActionResult DeleteCategory(Category category)
        {
            if (category is not null)
            {
                _serivce.Delete(new() { Id = category.Id });
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }

    }
}