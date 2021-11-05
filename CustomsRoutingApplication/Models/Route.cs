using System.Collections.Generic;

namespace CustomsRoutingApplication.Models
{
    public class DestinationRoute
    {
        public string Destination { get; set; }
        public List<string> Route { get; set; }

        public DestinationRoute(string destination)
        {
            this.Destination = destination;
            Route = RoutesDictionary.Routes[destination];
        }
    }

}