using KatzenpensionApi.ApiDtos.RequestDtos;
using Microsoft.AspNetCore.Mvc;

namespace KatzenpensionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IConfiguration configuration) : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestDto request)
        {
            var correctPw = configuration["AuthConfig:SitePassword"];

            if(request != null && request.Password == correctPw)
            {
                return Ok(new { success = true });
            }
            return Unauthorized(new { success = false, message = "Wrong Password" });
        }
    }
}
