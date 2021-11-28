
using System.IO;
using System.Net;
using System.Text;


namespace clawPDF.Service.utils
{
    class HttpUtil
    {
            public static string Post(string serviceUrl, string postData)
            {
                string result = "";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(serviceUrl);
                req.Method = "POST";
                //设置请求超时时间，单位为毫秒
                req.ReadWriteTimeout = 10000;
                req.ContentType = "application/json";
                byte[] data = Encoding.UTF8.GetBytes(postData);
                req.ContentLength = data.Length;
                //发送请求
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                //获取响应内容
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
                return result;
            }
    }
}
