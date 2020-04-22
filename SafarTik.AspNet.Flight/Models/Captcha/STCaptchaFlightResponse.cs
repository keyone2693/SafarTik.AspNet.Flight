using System;
using System.Collections.Generic;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STCaptchaFlightResponse
    {
        public string requestID { get; set; }
        public string captchaLink { get; set; }
    }
}
