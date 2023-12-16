using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using VirtualPetCareWebAPI.Business.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;

namespace VirtualPetCareWebAPI.WebAPI.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HealthStatusController : ControllerBase
    {
        IHealthStatusService _healthStatusService;

        public HealthStatusController(IHealthStatusService healthStatusService)
        {
            _healthStatusService = healthStatusService;
        }

        [HttpPost]
        public IActionResult Add(AddHealthStatusRequest addHealthStatusRequest)
        {
            var result = _healthStatusService.Add(addHealthStatusRequest);

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
        public IActionResult Update(UpdateHealthStatusRequest updateHealthStatusRequest)
        {
            var result = _healthStatusService.Update(updateHealthStatusRequest);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{healthStatusId}")]
        public IActionResult Delete([FromRoute] int healthStatusId)
        {
            var result = _healthStatusService.Delete(healthStatusId);

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
            var result = _healthStatusService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{healthStatusId}")]
        public IActionResult GetHealthStatusById([FromRoute] int healthStatusId)
        {
            var result = _healthStatusService.GetHealthStatusById(healthStatusId);

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
