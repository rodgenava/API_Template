using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebAPITempalate.Application;

namespace WebAPITempalate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    //[Authorize]
    public class WeatherForecastController : ControllerBase
    {

        public readonly IPricebook2ItemsService _pricebook2ItemsService;

        public WeatherForecastController(IPricebook2ItemsService pricebook2ItemsService)
        {
            _pricebook2ItemsService = pricebook2ItemsService;
        }

        [HttpGet("GettestAPI")]
        public async Task<IActionResult> GettestAPI()
        {
            var asdf = await _pricebook2ItemsService.Testconnection();

            if (asdf != null)
            {
                return (Ok(asdf));
            }
            return (NotFound());
        }
    }
}
