using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STPriceChangeInfo
    {
        [Description("increase | decrease")]
        public string type { get; set; }
        public STAdultPriceChange adl { get; set; }
        public STChildPriceChange chd { get; set; }
        public STInfantPriceChange inf { get; set; }
    }




}
