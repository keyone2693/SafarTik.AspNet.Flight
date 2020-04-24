using SafarTik.AspNet.Flight.Data;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SafarTik.AspNet.Flight.Models;
using System.Collections.Generic;
using SafarTik.AspNet.Flight.Extentions;

namespace SafarTik.AspNet.Flight
{
    public class SafarTikApi : ISafarTikApi, IDisposable
    {

        #region ctor
        private readonly HttpClient _http;
        private StringContent _content;
        private HttpResponseMessage _response;

        public SafarTikApi()
        {
            _http = new HttpClient();
        }
        #endregion

        #region AsyncMethods
        public async Task<SafarTikResult<STLoginResponse>> LoginAsync(STLoginRequest sTLoginRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(sTLoginRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Auth.Login, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<STLoginResponse>>(await _response.Content.ReadAsStringAsync());

                return new SafarTikResult<STLoginResponse>
                {
                    Status = res.Status,
                    Messages = null,
                    Result = res.Result
                };
            }
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<STLoginResponse>>(await _response.Content.ReadAsStringAsync());
                var err = res.Error.code.GetErrorMessage();
                return new SafarTikResult<STLoginResponse>
                {
                    Status = false,
                    Messages = err == "0" ? err : res.Error.message,
                    Result = null
                };
            }
        }

        public async Task<SafarTikResult<IEnumerable<STGetAirportsResponse>>> GetAirportsAsync(STGetAirportsRequest sTGetAirportsRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(sTGetAirportsRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Flight.Airports, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<STGetAirportsResponse>>>(await _response.Content.ReadAsStringAsync());

                return new SafarTikResult<IEnumerable<STGetAirportsResponse>>
                {
                    Status = res.Status,
                    Messages = null,
                    Result = res.Result
                };
            }
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<STGetAirportsResponse>>>(await _response.Content.ReadAsStringAsync());
                var err = res.Error.code.GetErrorMessage();
                return new SafarTikResult<IEnumerable<STGetAirportsResponse>>
                {
                    Status = false,
                    Messages = err == "0" ? err : res.Error.message,
                    Result = null
                };
            }
        }

        public async Task<SafarTikResult<IEnumerable<STAvailableFlightResponse>>> GetAvailableFlightAsync(STAvailableFlightRequest sTAvailableFlightRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(sTAvailableFlightRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Flight.Available, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<STAvailableFlightResponse>>>(await _response.Content.ReadAsStringAsync());

                return new SafarTikResult<IEnumerable<STAvailableFlightResponse>>
                {
                    Status = res.Status,
                    Messages = null,
                    Result = res.Result
                };
            }
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<STAvailableFlightResponse>>>(await _response.Content.ReadAsStringAsync());
                var err = res.Error.code.GetErrorMessage();
                return new SafarTikResult<IEnumerable<STAvailableFlightResponse>>
                {
                    Status = false,
                    Messages = err == "0" ? err : res.Error.message,
                    Result = null
                };
            }
        }

        public async Task<SafarTikResult<IEnumerable<STAvailable15DaysFlightResponse>>> GetAvailable15DaysFlightAsync(STAvailable15DaysFlightRequest sTAvailableFlightRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(sTAvailableFlightRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Flight.Available15Days, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<STAvailable15DaysFlightResponse>>>(await _response.Content.ReadAsStringAsync());

                return new SafarTikResult<IEnumerable<STAvailable15DaysFlightResponse>>
                {
                    Status = res.Status,
                    Messages = null,
                    Result = res.Result
                };
            }
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<IEnumerable<STAvailable15DaysFlightResponse>>>(await _response.Content.ReadAsStringAsync());
                var err = res.Error.code.GetErrorMessage();
                return new SafarTikResult<IEnumerable<STAvailable15DaysFlightResponse>>
                {
                    Status = false,
                    Messages = err == "0" ? err : res.Error.message,
                    Result = null
                };
            }
        }

        public async Task<SafarTikResult<STCaptchaFlightResponse>> GetCaptchaFlightAsync(STCaptchaFlightRequest sTCaptchaFlightRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(sTCaptchaFlightRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Flight.Captcha, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<STCaptchaFlightResponse>>(await _response.Content.ReadAsStringAsync());

                return new SafarTikResult<STCaptchaFlightResponse>
                {
                    Status = res.Status,
                    Messages = null,
                    Result = res.Result
                };
            }
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<STCaptchaFlightResponse>>(await _response.Content.ReadAsStringAsync());
                var err = res.Error.code.GetErrorMessage();
                return new SafarTikResult<STCaptchaFlightResponse>
                {
                    Status = false,
                    Messages = err == "0" ? err : res.Error.message,
                    Result = null
                };
            }
        }

        public async Task<SafarTikResult<STReserveFlightResponse>> ReserveFlightAsync(STReserveFlightRequest sTReserveFlightRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(sTReserveFlightRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Flight.Reservation, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<STReserveFlightResponse>>(await _response.Content.ReadAsStringAsync());

                return new SafarTikResult<STReserveFlightResponse>
                {
                    Status = res.Status,
                    Messages = null,
                    Result = res.Result
                };
            }
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<STReserveFlightResponse>>(await _response.Content.ReadAsStringAsync());
                var err = res.Error.code.GetErrorMessage();
                return new SafarTikResult<STReserveFlightResponse>
                {
                    Status = false,
                    Messages = err == "0" ? err : res.Error.message,
                    Result = null
                };
            }
        }

        public async Task<SafarTikResult<STBuyTicketResponse>> BuyTicketAsync(STBuyTicketRequest sTBuyTicketRequest)
        {
            _http.DefaultRequestHeaders.Clear();

            _content = new StringContent(
                JsonConvert.SerializeObject(sTBuyTicketRequest), UTF8Encoding.UTF8, "application/json");

            _response = await _http.PostAsync(ApiRoutes.Ticket.Buy, _content);

            if (_response.IsSuccessStatusCode)
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<STBuyTicketResponse>>(await _response.Content.ReadAsStringAsync());

                return new SafarTikResult<STBuyTicketResponse>
                {
                    Status = res.Status,
                    Messages = null,
                    Result = res.Result
                };
            }
            {
                var res = JsonConvert.DeserializeObject<ServiceResult<STBuyTicketResponse>>(await _response.Content.ReadAsStringAsync());
                var err = res.Error.code.GetErrorMessage();
                return new SafarTikResult<STBuyTicketResponse>
                {
                    Status = false,
                    Messages = err == "0" ? err : res.Error.message,
                    Result = null
                };
            }
        }
        #endregion

        #region Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _http.Dispose();
                    if (_content != null)
                        _content.Dispose();
                    if (_response != null)
                        _response.Dispose();
                    //
                    disposed = true;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



        ~SafarTikApi()
        {
            Dispose(true);
        }
        #endregion

    }
}
