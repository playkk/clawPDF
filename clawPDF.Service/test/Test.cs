

using Newtonsoft.Json;
using System;
using clawPDF.Service.domian;
using clawPDF.Service.typeEnum;
using clawPDF.Service.utils;


namespace clawPDF.Service.test
{
    class Test
    {

        static void  Main(string[] paramas)
        {
            /*ISettingService service = new SettingService();
              if (paramas.Length > 0) {
                  string filename = paramas[0];         
                  if (!string.IsNullOrEmpty(filename))
                  {
                      service.SetFileName(filename);
                  }
              }*/
            PrintInfoVo vo = new PrintInfoVo();
            string timeStamp = getTimeStamp();
            string uuid = Guid.NewGuid().ToString();
            vo.startTime = timeStamp;
            vo.endTime = timeStamp;
            vo.fileName = "hello.pdf";
            vo.filePath = "D:/TEMP/PDF";
            vo.printerName = "clawPDF";
            vo.printStatus = Printststus.printing;
            vo.jobId = uuid;
            string printInfoStr = JsonConvert.SerializeObject(vo);
            string url = "http://127.0.0.1:12246/receivePrintRecord";
            string reuslt = HttpUtil.Post(url, printInfoStr);
        }

        public static string getTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }
}
