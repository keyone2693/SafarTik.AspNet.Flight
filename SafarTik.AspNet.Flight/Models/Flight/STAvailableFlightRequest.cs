using System;
using System.Collections.Generic;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STAvailableFlightRequest
    {
        public string sessionID { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string date { get; set; }
    }
}
