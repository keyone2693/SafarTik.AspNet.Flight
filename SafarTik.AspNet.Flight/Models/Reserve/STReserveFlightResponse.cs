using System;
using System.Collections.Generic;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STReserveFlightResponse
    {
        public string voucher { get; set; }
        public bool duplicate { get; set; }
        public int totalPrice { get; set; }
        public STPassengersInfo passengersInfo { get; set; }
        public STPriceChangeInfo priceChangeInfo { get; set; }
    }
}
