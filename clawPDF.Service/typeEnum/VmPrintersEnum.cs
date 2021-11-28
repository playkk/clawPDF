using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace clawPDF.Service.typeEnum
{
    public class VmPrintersEnum
    {

        public VmPrintersEnum()
        {
            
        }

        /**
         * 需要返回打印信息的虚拟打印机列表.
         */
        public static Dictionary<String, String> getPrinterMap()
        {
            Dictionary<String, String> printerMap = new Dictionary<String, String>();
            printerMap.Add("clawPDFA", "clawPDFA");
            printerMap.Add("clawPDFB", "clawPDFB");
            printerMap.Add("clawPDFC", "clawPDFC");
            printerMap.Add("clawPDFD", "clawPDFD");
            printerMap.Add("clawPDFE", "clawPDFE");
            printerMap.Add("clawPDF1", "clawPDF1");
            printerMap.Add("clawPDF2", "clawPDF2");
            printerMap.Add("clawPDF3", "clawPDF3");
            printerMap.Add("clawPDF4", "clawPDF4");
            printerMap.Add("clawPDF5", "clawPDF5");
            return printerMap;
        }
    }
}