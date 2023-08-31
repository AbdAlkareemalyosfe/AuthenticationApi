using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Authentication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecuredController : ControllerBase
    {
        // GET: api/<AuthenticationController>
        [HttpGet("GetUseresAfterAuthontication")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok();
        }

        // GET api/<AuthenticationController>/5
        [HttpGet("GetUserAfterAuthentication/{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            return Ok();
        }

      
    }
}
