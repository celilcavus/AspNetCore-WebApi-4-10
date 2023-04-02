using CelilCavus.WebApi.Entites;
using CelilCavus.WebApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> _service;

        public ProductController(IRepository<Product> service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetProduct()
        {
            var values = _service.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int? id)
        {
            int isNullId = id ?? -1;
            if (isNullId is not <= 0)
            {
                var values = _service.GetById(isNullId);
                return Ok(values);
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }

        [HttpPost]
        public IActionResult PostProduct(Product Product)
        {
            var isNull = Product ?? null;
            if (isNull is not null)
            {
                _service.Add(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
        [HttpPut]
        public IActionResult PutProduct(Product Product)
        {
            var isNull = Product ?? null;
            if (isNull is not null)
            {
                _service.Update(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
        [HttpDelete]
        public IActionResult DeleteProduct(Product Product)
        {
            var isNull = Product ?? null;
            if (isNull is not null)
            {
                _service.Delete(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }

    }
}