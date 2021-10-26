using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment02_WebAPI.Data;
using Assignment02_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdultController : ControllerBase
    {
        private IList<Adult> adults;
        private IAdultData adultData;

        public AdultController(IAdultData adultData)
        {
            this.adultData = adultData;
        }
        
        // GET: Adult
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults([FromQuery] string? lastname)
        {
            try
            {
                adults = adultData.GetAdults();
                if (lastname != null)
                {
                    adults = adults.Where(a => a.LastName == lastname).ToList();
                }


                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        // POST: Family
        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromQuery] string firstName, [FromQuery] string lastName,
            [FromQuery] string hairColor, [FromQuery] string eyeColor, [FromQuery] int age, [FromQuery] float weight,
            [FromQuery] int height, [FromQuery] string sex, [FromQuery] string jobtitle, [FromQuery] int salary,
            [FromQuery] string streetName, [FromQuery] int houseNumber)
        {
            try
            {
                Adult toAdd = new Adult()
                {
                    FirstName = firstName, 
                    LastName = lastName
                };
                adultData.AddAdult(firstName, lastName, hairColor, eyeColor, age, weight, height, sex, jobtitle,
                    salary, streetName, houseNumber);
                return Created($"/{toAdd.FirstName}", toAdd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        // DELETE: Family/5
        [HttpDelete]
        [Route("{id:int}")]
        public  async Task<ActionResult<Adult>>  RemoveAdult([FromRoute] int id)
        {
            try
            {
                adultData.RemoveAdult(id);
                
                return StatusCode(999, "removed adult with ID: " + id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}