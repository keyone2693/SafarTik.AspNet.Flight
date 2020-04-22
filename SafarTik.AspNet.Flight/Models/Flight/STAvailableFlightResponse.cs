using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SafarTik.AspNet.Flight.Models
{
    public class STAvailableFlightResponse
    {
        public string uniqueID { get; set; }
        public string type { get; set; }
        public int price_final { get; set; }
        public int price_final_chd { get; set; }
        public int price_final_inf { get; set; }
        public int price_final_fare { get; set; }
        public int price_final_chd_fare { get; set; }
        public int price_final_inf_fare { get; set; }
        public int capacity { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string number_flight { get; set; }
        [Description("بیزینس | اکونومی")]
        public string type_flight { get; set; }
        public string carrier { get; set; }
        public string date_flight { get; set; }
        public string time_flight { get; set; }
        public string airline { get; set; }
        public string IATA_code { get; set; }
        public string cabinclass { get; set; }
        [Description("YES | NO")]
        public string weelchairsupport { get; set; }
        public int price_Markup { get; set; }
        [Description("1 = اشتراکی")]
        public string Share_Sale { get; set; }
        [Description("1 = با توقف")]
        public string has_stop { get; set; }
    }
}
