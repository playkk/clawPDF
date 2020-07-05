using System.Text;
using pdfforge.DataStorage;

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
    ///     AutoSave allows to create PDF files without user interaction
    /// </summary>
    public class AutoSave
    {
        public AutoSave()
        {
            Init();
        }
        /// <summary>
        /// 是否开启自动保存
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        ///     Existing files will not be overwritten. Existing filenames automatically get an appendix.
        ///     是否保证文件名唯一性
        /// </summary>
        public bool EnsureUniqueFilenames { get; set; }

        /// <summary>
        /// 文件保存目录
        /// </summary>
        public string TargetDirectory { get; set; }

        private void Init()
        {
            //默认启用自动保存
            Enabled = true;
            //默认启用文件名的唯一
            EnsureUniqueFilenames = true;
            //默认保存文件路径
            TargetDirectory = "C:\\TEMP\\PDF";
        }

        public void ReadValues(Data data, string path)
        {
            try
            {
                Enabled = bool.Parse(data.GetValue(@"" + path + @"Enabled"));
            }
            catch
            {
                Enabled = false;
            }

            try
            {
                EnsureUniqueFilenames = bool.Parse(data.GetValue(@"" + path + @"EnsureUniqueFilenames"));
            }
            catch
            {
                EnsureUniqueFilenames = true;
            }

            try
            {
                TargetDirectory = Data.UnescapeString(data.GetValue(@"" + path + @"TargetDirectory"));
            }
            catch
            {
                TargetDirectory = "";
            }

        }

        public void StoreValues(Data data, string path)
        {
            data.SetValue(@"" + path + @"Enabled", Enabled.ToString());
            data.SetValue(@"" + path + @"EnsureUniqueFilenames", EnsureUniqueFilenames.ToString());
            data.SetValue(@"" + path + @"TargetDirectory", Data.EscapeString(TargetDirectory));
        }

        public AutoSave Copy()
        {
            var copy = new AutoSave();

            copy.Enabled = Enabled;
            copy.EnsureUniqueFilenames = EnsureUniqueFilenames;
            copy.TargetDirectory = TargetDirectory;

            return copy;
        }

        public override bool Equals(object o)
        {
            if (!(o is AutoSave)) return false;
            var v = o as AutoSave;

            if (!Enabled.Equals(v.Enabled)) return false;
            if (!EnsureUniqueFilenames.Equals(v.EnsureUniqueFilenames)) return false;
            if (!TargetDirectory.Equals(v.TargetDirectory)) return false;

            return true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Enabled=" + Enabled);
            sb.AppendLine("EnsureUniqueFilenames=" + EnsureUniqueFilenames);
            sb.AppendLine("TargetDirectory=" + TargetDirectory);

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