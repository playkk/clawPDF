using clawPDF.Service.service;
using clawSoft.clawPDF.Core.Settings;
using System;


namespace clawPDF.Service.imple
{
    class SettingService : ISettingService
    {

        public SettingService()
        {
            

        }
        public void SetFileName(string name)
        {
            FileName.Init();
            FileInfo fileinfo = new FileInfo();
            fileinfo.Name = name;
            fileinfo.JobId = "";
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            fileinfo.StartTime = Convert.ToInt64(ts.TotalSeconds).ToString();
            ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            fileinfo.EndTime = Convert.ToInt64(ts.TotalSeconds).ToString();
            fileinfo.PrintState = "0";
            FileName.modifyFileInfo(fileinfo);
        }
    }
}
