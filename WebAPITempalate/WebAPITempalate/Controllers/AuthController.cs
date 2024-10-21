using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPITempalate.Application;
using WebAPITempalate.Domain;

namespace WebAPITempalate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;

        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        //Test using postman
        //[FromBody] use body->raw->json in postman
        //[FromForm] use param in postman 
        //[FromHeader] use header in postman
        [HttpGet("CreateToken")]
        public Task<IActionResult> CreateToken([FromBody] LoginModel login)
        {
            var tokenString = _jwtService.CreateToken(login);

            if (tokenString != null && tokenString != "")
            {
                //return Ok(new { Token = tokenString });
                return Task.FromResult<IActionResult>(Ok(tokenString));
            }
            return Task.FromResult<IActionResult>(Unauthorized());
        }
    }
}
