using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using VirtualPetCareWebAPI.Business.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;

namespace VirtualPetCareWebAPI.WebAPI.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        IFoodService _foodService;

        public FoodsController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpPost]
        public IActionResult Add(AddFoodRequest addFoodRequest)
        {
            var result = _foodService.Add(addFoodRequest);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update(UpdateFoodRequest updateFoodRequest)
        {
            var result = _foodService.Update(updateFoodRequest);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{foodId}")]
        public IActionResult Delete([FromRoute] int foodId)
        {
            var result = _foodService.Delete(foodId);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _foodService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{foodId}")]
        public IActionResult GetFoodById([FromRoute] int foodId)
        {
            var result = _foodService.GetFoodById(foodId);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
