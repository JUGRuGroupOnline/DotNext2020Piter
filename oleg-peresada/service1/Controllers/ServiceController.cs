using Microsoft.AspNetCore.Mvc;

namespace service1.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {
        [HttpGet("/")]
        public ActionResult Get() 
        {
            return Ok("На");
        }
    }
}