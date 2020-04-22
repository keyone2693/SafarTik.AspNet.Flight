using System;
using System.Collections.Generic;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STCaptchaFlightRequest
    {
        public string sessionID { get; set; }
        public string uniqueID { get; set; }
    }
}
