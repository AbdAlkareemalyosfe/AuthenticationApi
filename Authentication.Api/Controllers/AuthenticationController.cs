using Authentication.Api.DatTransferObject_Dto_;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Authentication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // GET: api/<AuthController>
        [HttpPost("RegisterUser")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            return Ok();
        }

        // GET api/<AuthController>/5
       

        // POST api/<AuthController>
        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn([FromBody] LogInDto logInDto)
        {
            return Ok();
        }

        // PUT api/<AuthController>/
        
        [HttpGet("RefreshToken")]
        public async Task<IActionResult> RefreshToken(string token)
        {
        return Ok();
        }
    }
}
