using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
       
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

            
        }

        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int id)
        {
            var result =_carService.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        [HttpPost("add")]
        public IActionResult Add(Cars car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        
        [HttpPut("update")]
        public IActionResult Update(Cars car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

       
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _carService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
