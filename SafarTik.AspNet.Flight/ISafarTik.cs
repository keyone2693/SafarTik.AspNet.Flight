
using SafarTik.AspNet.Flight.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafarTik.AspNet.Flight
{
    public interface ISafarTik
    {
        Task<SafarTikResult<STLoginResponse>> LoginAsync(STLoginRequest sTLoginRequest);

        Task<SafarTikResult<IEnumerable<STGetAirportsResponse>>> GetAirportsAsync(STGetAirportsRequest sTGetAirportsRequest);

        Task<SafarTikResult<IEnumerable<STAvailableFlightResponse>>> GetAvailableFlightAsync(STAvailableFlightRequest sTAvailableFlightRequest);

        Task<SafarTikResult<IEnumerable<STAvailable15DaysFlightResponse>>> GetAvailable15DaysFlightAsync(STAvailable15DaysFlightRequest sTAvailableFlightRequest);


        Task<SafarTikResult<STCaptchaFlightResponse>> GetCaptchaFlightAsync(STCaptchaFlightRequest sTCaptchaFlightRequest);

        Task<SafarTikResult<STReserveFlightResponse>> ReserveFlightAsync(STReserveFlightRequest sTReserveFlightRequest);



    }
}
