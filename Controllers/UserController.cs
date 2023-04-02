using CelilCavus.WebApi.Entites;
using CelilCavus.WebApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _service;

        public UserController(IRepository<User> service)
        {
            _service = service;
        }

       
        [HttpGet]
        public IActionResult GetUser()
        {
            var values = _service.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetUser(int? id)
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
        public IActionResult PostUser(User User)
        {
            var isNull = User ?? null;
            if (isNull is not null)
            {
                _service.Add(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
        [HttpPut]
        public IActionResult PutUser(User User)
        {
            var isNull = User ?? null;
            if (isNull is not null)
            {
                _service.Update(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
        [HttpDelete]
        public IActionResult DeleteUser(User User)
        {
            var isNull = User ?? null;
            if (isNull is not null)
            {
                _service.Delete(isNull);
                return NoContent();
            }
            else return StatusCode(StatusCodes.Status404NotFound);
        }
    }
}