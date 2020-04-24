

using Microsoft.Extensions.DependencyInjection;

namespace SafarTik.AspNet.Flight.Extentions
{
   public static class Common
    {
        public static IServiceCollection AddMadpay724GateWay(this IServiceCollection services)
        {
            return services.AddScoped<ISafarTikApi, SafarTikApi>();
        }


        public static string GetErrorMessage(this int Code)
        {
            switch (Code)
            {
                case 1001:
                    return "مقدار username ارسال نشده است ";
                case 1002:
                    return "مقدار password ارسال نشده است ";
                case 1003:
                    return "نام کاربری یا کلمه عبور نادرست است ";
                case 1004:
                    return "مقدار sessionID ارسال نشده است ";
                case 1005:
                    return "مبدا ارسال نشده است ";
                case 1006:
                    return "مقصد ارسال نشده است ";
                case 1007:
                    return "مبدا و مقصد نمی تواند یکسان باشد ";
                case 1008:
                    return "تاریخ پرواز ارسال نشده است ";
                case 1009:
                    return "تاریخ پرواز نادرست است ";
                case 1010:
                    return "تاریخ پرواز منقضی شده است ";
                case 1011:
                    return "کد فرودگاه مبدا نادرست است ";
                case 1012:
                    return "کد فرودگاه مقصد نادرست است ";
                case 1013:
                    return " نادرست است sessionID";
                case 1014:
                    return "sessionID منقضی شده است ";
                case 1015:
                    return "بروز خطای نامشخص ";
                case 1016:
                    return "شناسه پرواز ارسال نشده است ";
                case 1017:
                    return "شناسه پرواز نادرست است ";
                case 1018:
                    return "کد رزرو موقت )requestID( ارسال نشده است ";
                case 1019:
                    return "کد کپچا وارد نشده است ";
                case 1020:
                    return "شماره موبایل وارد نشده است ";
                case 1021:
                    return "آدرس ایمیل وارد نشده است ";
                case 1022:
                    return "لیست اسامی مسافرین ارسال نشده است ";
                case 1023:
                    return "خطای متغییر با توجه به مشخصات رزرو ";
                case 1024:
                    return "شماره واچر ارسال نشده است ";
                case 1025:
                    return "شماره واچر صحیح نیست ";
                case 1026:
                    return "بلیط پیش از این صادر شده است ";
                case 999:
                    return "خطای وبسرویس ";
                default:
                    return "0";
            }
        }

    }
}
