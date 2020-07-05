using System.Text;


// Custom Code starts here
// START_CUSTOM_SECTION:INCLUDES
// END_CUSTOM_SECTION:INCLUDES
// Custom Code ends here. Do not edit below

// ! This file is generated automatically.
// ! Do not edit it outside the sections for custom code.
// ! These changes will be deleted during the next generation run

namespace clawSoft.clawPDF.Core.Settings
{
    /// <summary>
    ///     Inserts one or more pages at the beginning of the converted document
    /// </summary>
    public class FileInfo
    {

        /// <summary>
        ///     打印开始时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        ///     打印结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        ///     打印状态
        /// </summary>
        public string PrintState { get; set; }

        /// <summary>
        ///     打印线程ID
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        ///     文件名
        /// </summary>
        public string Name { get; set; }


        public override bool Equals(object o)
        {
            if (!(o is FileInfo)) return false;
            var v = o as FileInfo;

            if (!StartTime.Equals(v.StartTime)) return false;
            if (!EndTime.Equals(v.EndTime)) return false;
            if (!PrintState.Equals(v.PrintState)) return false;
            if (!JobId.Equals(v.JobId)) return false;
            if (!Name.Equals(v.Name)) return false;

            return true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("StartTime=" + StartTime);
            sb.AppendLine("EndTime=" + EndTime);
            sb.AppendLine("PrintState=" + PrintState);
            sb.AppendLine("JobId=" + JobId);
            sb.AppendLine("Name=" + Name);

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