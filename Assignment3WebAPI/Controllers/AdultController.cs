using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment3WebAPI.Data;
using Assignment3WebAPI.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        public IfileContext _Context;

        public AdultController(IfileContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults
        (
            [FromQuery] string sex,
            [FromQuery] string firstName,
            [FromQuery] string lastName,
            [FromQuery] string eyeColour,
            [FromQuery] string hairColor,
            [FromQuery] int? height,
            [FromQuery] int? weight,
            [FromQuery] int? id,
            [FromQuery] string jobTitle,
            [FromQuery] int? age)
        {
            IList<Adult> adults = await _Context.getAllAdults(sex, firstName, lastName, eyeColour, hairColor, height,
                weight, id, jobTitle, age);
            return Ok(adults);
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Adult adultAdded = await _Context.AddAdult(adult);
                return Created($"/{adultAdded.Id}", adultAdded);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Adult>> DeleteAdult(int id)
        {
            Console.WriteLine("her Delete");
            try
            {
                var adultToDelete = await _Context.getAdult(id);

                if (adultToDelete == null)
                {
                    return NotFound($"Employee with Id = {id} not found");
                }

                await _Context.removeAdult(id);
                return  Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}