using Microsoft.AspNetCore.Mvc;
using CustomsRoutingApplication.Models;

namespace CustomsRoutingApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        public Controller()
        {
        }

        [HttpGet("{destination}")]
        public ActionResult<DestinationRoute> Get(string destination)
        {
            destination = destination.ToUpper();

            if (RoutesDictionary.Routes.ContainsKey(destination))
                return new DestinationRoute(destination);
            else
                return NotFound();
        }

    }
}
