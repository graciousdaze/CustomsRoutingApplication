using System.Collections.Generic;

namespace CustomsRoutingApplication.Models
{
    public static class RoutesDictionary
    {
        public static readonly Dictionary<string, List<string>> Routes = new()
        {
            { "CAN", new List<string> { "US", "CAN" } },
            { "US", new List<string> { "US" } },
            { "MEX", new List<string> { "US", "MEX" } },
            { "BLZ", new List<string> { "US", "MEX", "BLZ" } },
            { "GTM", new List<string> { "US", "MEX", "GTM" } },
            { "SLV", new List<string> { "US", "MEX", "GTM", "SLV" } },
            { "HND", new List<string> { "US", "MEX", "GTM", "HND" } },
            { "NIC", new List<string> { "US", "MEX", "GTM", "HND", "NIC" } },
            { "CRI", new List<string> { "US", "MEX", "GTM", "HND", "NIC", "CRI" } },
            { "PAN", new List<string> { "US", "MEX", "GTM", "HND", "NIC", "CRI", "PAN" } }
        };

    }
}