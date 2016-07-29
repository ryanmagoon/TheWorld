using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.Models;

namespace TheWorld.Controllers.Api
{
    public class TripsController : Controller
    {
        [HttpGet("api/trips")]
        public IActionResult Get()
        {
            if (true) return BadRequest("Bad things happened");
            return Ok(new Trip() { Name = "My Trip" });
        }
    }
}
