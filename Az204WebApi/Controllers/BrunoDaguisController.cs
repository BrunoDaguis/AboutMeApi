using Az204WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Az204WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BrunoDaguisController : ControllerBase
    {
        [HttpGet]        
        public AboutModel Get([FromServices] IOptions<AboutModel> options)
        {
            return options.Value;
        }
    }
}