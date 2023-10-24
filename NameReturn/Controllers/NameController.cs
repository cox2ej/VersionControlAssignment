using Microsoft.AspNetCore.Mvc;

namespace YourWebApiName.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var name = "Ethan Cox";
            return Ok(new { Name = name });
        }
    }
}
