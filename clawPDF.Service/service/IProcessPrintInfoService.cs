using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clawPDF.Service.domian;

namespace clawPDF.Service.service
{
    public interface IProcessPrintInfoService
    {
        /**
         * 发送打印信息.
         */
        bool sendPrintInfo(PrintInfoVo printInfoVo);
    }
}

