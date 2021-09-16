using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGPrinter.Service.domian;

namespace YGPrinter.Service.service
{
    interface IProcessPrintInfoService
    {
        /**
         * 发送打印信息.
         */
        String sendPrintInfo(PrintInfoVo printInfoVo);
    }
}
