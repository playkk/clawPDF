using System.Text;
using clawPDF.Service.typeEnum;

namespace clawPDF.Service.domian
{
    public class PrintInfoVo
    {
        /// <summary>
        ///     打印开始时间
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     打印结束时间
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        ///     打印状态
        /// </summary>
        public Printststus printStatus { get; set; }

        /// <summary>
        ///     打印线程ID
        /// </summary>
        public string jobId { get; set; }

        /// <summary>
        ///     文件名
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        ///     文件路径
        /// </summary>
        public string filePath { get; set; }

        /// <summary>
        ///     虚拟机名称
        /// </summary>
        public string printerName { get; set; }


        public override bool Equals(object o)
        {
            if (!(o is PrintInfoVo)) return false;
            var v = o as PrintInfoVo;

            if (!startTime.Equals(v.startTime)) return false;
            if (!endTime.Equals(v.endTime)) return false;
            if (!printStatus.Equals(v.printStatus)) return false;
            if (!jobId.Equals(v.jobId)) return false;
            if (!fileName.Equals(v.fileName)) return false;
            if (!filePath.Equals(v.filePath)) return false;
            if (!printerName.Equals(v.printerName)) return false;
            return true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("startTime=" + startTime);
            sb.AppendLine("endTime=" + endTime);
            sb.AppendLine("printStatus=" + printStatus);
            sb.AppendLine("jobId=" + jobId);
            sb.AppendLine("fileName=" + fileName);
            sb.AppendLine("filePath=" + filePath);
            sb.AppendLine("printerName=" + printerName);
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
            return base.GetHashCode();
        }

        // Custom Code starts here
        // START_CUSTOM_SECTION:GENERAL
        // END_CUSTOM_SECTION:GENERAL
        // Custom Code ends here. Do not edit below

    }
}
