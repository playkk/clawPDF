using clawPDF.Service.service;
using clawPDF.Service.domian;
using clawPDF.Service.utils;
using Newtonsoft.Json;

namespace clawPDF.Service.imple
{
    public class ProcessPrintInfoService : IProcessPrintInfoService
    {

        public ProcessPrintInfoService()
        {
            

        }

        public bool sendPrintInfo(PrintInfoVo printInfoVo)
        {
            string printInfoStr = JsonConvert.SerializeObject(printInfoVo);
            string url = "http://127.0.0.1:12246/receivePrintRecord";
            string reuslt = HttpUtil.Post(url, printInfoStr);
            return true;
        }
    }
}

