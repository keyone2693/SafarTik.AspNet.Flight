using System;
using System.Collections.Generic;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STBuyTicketRequest
    {
        public string sessionID { get; set; }
        public string voucher { get; set; }
    }
}
