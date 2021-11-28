
using System;


namespace clawPDF.Service.utils
{
    public class DateUtil
    {
            public static string nowDate2Str()
            {
                string nowTime = DateTime.Now.ToString() + DateTime.Now.Millisecond.ToString();
                nowTime = nowTime.Replace("-", "");
                nowTime = nowTime.Replace("/", "");
                nowTime = nowTime.Replace(" ", "");
                nowTime = nowTime.Replace(":", "");
            return nowTime;
            }
    }
}
