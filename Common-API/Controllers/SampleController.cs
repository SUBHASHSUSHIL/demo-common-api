using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Common_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GenerateError()
        {
            // Yahan ek intentional error ho raha hai
            throw new Exception("Something went wrong!");
        }
    }
}
