using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STPassengersInfo
    {
        [Description("ADL  | CHD | INF")]
        public string type { get; set; }
        public string firstname_en { get; set; }
        public string lastname_en { get; set; }
        public string real_price { get; set; }
        public string fare { get; set; }
    }
}
