using FlightLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightLog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Authenticate([FromBody] LoginModel login)
        {
            // TODO: Implement authentication logic here
            // For example, you could check the username and password against a database

            if (login.Username == "example" && login.Password == "password")
            {
                // Authentication succeeded
                return Ok(new { token = "abc123" }); // Return a token for the client to use in subsequent requests
            }
            else
            {
                // Authentication failed
                return Unauthorized();
            }
        }
    }
}
