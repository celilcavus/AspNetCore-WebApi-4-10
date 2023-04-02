using CelilCavus.WebApi.Entites;
using CelilCavus.WebApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IRepository<Orders> _service;

        public OrdersController(IRepository<Orders> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var values = _service.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetOrders(int? id)
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
        public IActionResult PostOrders(Orders orders)
        {
            var isNull = orders ?? null;
            if (isNull is not null)
            {
                _service.Add(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
        [HttpPut]
        public IActionResult PutOrders(Orders orders)
        {
            var isNull = orders ?? null;
            if (isNull is not null)
            {
                _service.Update(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
        [HttpDelete]
        public IActionResult DeleteOrders(Orders orders)
        {
            var isNull = orders ?? null;
            if (isNull is not null)
            {
                _service.Delete(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
    }
}