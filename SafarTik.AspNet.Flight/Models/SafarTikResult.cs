
using System.ComponentModel;

namespace SafarTik.AspNet.Flight.Models
{
    public class SafarTikResult<T>
    {
        [Description("وضعیت درخواست ارسال شده")]
        public bool Status { get; set; }
        [Description("پیغام سرور به درخواست ارسال شده")]
        public string Messages { get; set; }
        [Description("نتیجه ی درخواست ارسال شده")]
        public T Result { get; set; }
    }
}
