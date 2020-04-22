using System;
using System.Collections.Generic;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STReserveFlightRequest
    {
        public string sessionID { get; set; }
        public string uniqueID { get; set; }
        public string requestID { get; set; }
        public string captchaCode { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public IEnumerable<STPassengers> passengers { get; set; }
    }
}
