
using System.ComponentModel;

namespace SafarTik.AspNet.Flight.Models
{
    internal class ServiceError
    {
        internal int code { get; set; }
        internal string message { get; set; }
    }
    internal class ServiceResult<T>
    {
        [Description("وضعیت درخواست ارسال شده")]
        internal bool Status { get; set; }
        [Description("پیغام سرور به درخواست ارسال شده")]
        internal ServiceError Error { get; set; } = null;
        [Description("نتیجه ی درخواست ارسال شده")]
        internal T Result { get; set; }
    }
}
