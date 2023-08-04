using Microsoft.AspNetCore.Mvc;

namespace ToTo.Web.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonContorller : ControllerBase
    {
        public PersonContorller() { }


        [HttpGet("GetPerson")]
        public async Task<ActionResult<string>> GetPerson()
        {
            string result = "hello";
            return result;
        }
    }
}
