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

        [HttpGet]
        public ActionResult<DestinationRoute> Get()
        {
            return new OkObjectResult("To find a route from the US, add the destination's country code to the end of the domain.\nValid Codes: CAN, US, MEX, BLZ, GTM, SLV, HND, NIC, CRI, PAN ");
        }

        [HttpGet("{destination}")]
        public ActionResult<DestinationRoute> Get(string destination)
        {
            destination = destination.ToUpper();

            if (RoutesDictionary.Routes.ContainsKey(destination))
                return new DestinationRoute(destination);
            else
                return NotFound("Invalid country code. Use one of the following: CAN, US, MEX, BLZ, GTM, SLV, HND, NIC, CRI, PAN ");
        }

    }
}
