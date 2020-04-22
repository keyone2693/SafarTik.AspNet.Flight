using System;
using System.Collections.Generic;
using System.Text;

namespace SafarTik.AspNet.Flight.Data
{
    internal static class ApiRoutes
    {
        private const string BaseUrl = "https://safartik.ir/api";
        private const string BaseApi = BaseUrl;

        internal static class Auth
        {
            internal const string Login = BaseApi + "/login";
        }
        internal static class Flight
        {
            internal const string Airports = BaseApi + "/flight/airports";

            internal const string Available = BaseApi + "/flight/available";

            internal const string Available15Days = BaseApi + "/flight/available15Days";

            internal const string Captcha = BaseApi + "/flight/captcha";

            internal const string Reservation = BaseApi + "/flight/reservation";

            internal const string BuyTicket = BaseApi + "/flight/buy-ticket";


        }
        internal static class Ticket
        {
            internal const string Buy = BaseApi + "/flight/buy-ticket";
        }
    }
}
