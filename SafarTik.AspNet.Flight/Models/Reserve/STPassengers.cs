using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STPassengers
    {
        [Description("ADL | CHD | INF")]
        public string type { get; set; }
        public string firstname_fa { get; set; }
        public string lastname_fa { get; set; }
        public string firstname_en { get; set; }
        public string lastname_en { get; set; }
        [Description("male | female")]
        public string gender { get; set; }
        [Description("ir | fo")]
        public string nationality { get; set; }
        public string passenger_code { get; set; }
        public string expdate { get; set; }
        public string birthday { get; set; }
        public string nationality_code { get; set; }
    }
}
