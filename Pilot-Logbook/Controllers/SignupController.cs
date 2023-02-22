using FlightLog.Models;
using FlightLog.Repoitory;
using Microsoft.AspNetCore.Mvc;

namespace FlightLog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SignupController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public SignupController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Signup([FromBody] SignupModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _userRepository.GetByUsernameAsync(model.Username) == null)
                {
                    var user = new User
                    {
                        Email = model.Email,
                        Password = model.Password,
                        Name = model.Username
                    };
                    await _userRepository.AddUserAsync(user);
                    return Ok();
                }
                else
                {
                    return BadRequest("A user with this email address already exists.");
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}