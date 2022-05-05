using System;
using Microsoft.AspNetCore.Mvc;

namespace CashflowAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        // GET health
        [HttpGet]
        public ActionResult Health()
        {
            Console.WriteLine("Health check");
            return Ok();
        }
    }
}