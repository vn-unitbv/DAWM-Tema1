using Core.Dtos;
using Core.Services;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/apartments")]
    public class ApartmentsController : ControllerBase
    {
        private readonly ApartmentService apartmentService;


        public ApartmentsController(ApartmentService apartmentService)
        {
            this.apartmentService = apartmentService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<ApartmentBriefDto>> GetAll()
        {
            var results = apartmentService.GetAll();

            return Ok(results);
        }

        [HttpGet("/get/{apartmentId}")]
        public ActionResult<ApartmentDto> GetById(int apartmentId)
        {
            ApartmentDto? result = apartmentService.GetById(apartmentId);

            if (result == null)
                return BadRequest("Apartment not found");

            return Ok(result);
        }

        [HttpPatch("/edit-area")]
        public ActionResult<bool> EditArea([FromBody] ApartmentUpdateAreaDto apartmentUpdateModel)
        {
            var result = apartmentService.EditArea(apartmentUpdateModel);

            if (!result)
                return BadRequest("Apartment could not be updated.");

            return result;
        }

        [HttpDelete("/delete/{apartmentId}")]
        public ActionResult<bool> DeleteById([FromBody] int apartmentId)
        {
            var result = apartmentService.DeleteById(apartmentId);

            return Ok(result);
        }

    }
}
