﻿using System;
using System.IO;
using clawSoft.clawPDF.Core.Actions;
using clawSoft.clawPDF.Core.Jobs;
using clawSoft.clawPDF.Core.Settings;
using clawSoft.clawPDF.Utilities;
using FileInfo = clawSoft.clawPDF.Core.Settings.FileInfo;

namespace clawSoft.clawPDF.Workflow
{
    /// <summary>
    ///     The autosave workflow implements the workflow steps with auto save. Most interaction requests are answered with
    ///     default values or are rejected, as no interaction is possible.
    /// </summary>
    internal class AutoSaveWorkflow : ConversionWorkflow
    {
        /// <summary>
        ///     Create a new Workflow object with the given job info
        /// </summary>
        /// <param name="job">Job to use for the conversion</param>
        /// <param name="settings">Settings to use during the conversion workflow</param>
        public AutoSaveWorkflow(IJob job, clawPDFSettings settings)
        {
            WorkflowStep = WorkflowStep.Init;

            JobInfo = job.JobInfo;
            Job = job;
            Settings = settings;
        }

        protected override void QueryTargetFile()
        {
            var tr = Job.TokenReplacer;

            var outputFolder =
                FileUtil.Instance.MakeValidFolderName(tr.ReplaceTokens(Job.Profile.AutoSave.TargetDirectory));
       
            string filePath = "";
            if (!string.IsNullOrEmpty(Job.OutFileName))
            {
                filePath = Path.Combine(outputFolder, Job.OutFileName);
                Logger.Debug("打印文件生成路径 " + filePath);
            }
            else
            {
                string OutFileName = Job.ComposeOutputFilename();
                filePath = Path.Combine(outputFolder, OutFileName);
                Logger.Debug("打印文件生成路径 " + filePath);
                //将文件信息写到注册表
                Job.OutFileName = OutFileName;
                string strTime = DateTime.Now.ToString() + DateTime.Now.Millisecond.ToString();
                strTime = strTime.Replace("-", "");
                strTime = strTime.Replace(" ", "");
                strTime = strTime.Replace(":", "");
                FileInfo info = new FileInfo();
                info.JobId = System.Guid.NewGuid().ToString();
                info.Name = OutFileName;
                info.StartTime = strTime;
                info.EndTime = "";
                info.PrintState = "1";
                FileName.Init();
                FileName.modifyFileInfo(info);
                Logger.Debug("打印文件信息写入注册表");
            }

            try
            {
                filePath = FileUtil.Instance.EllipsisForTooLongPath(filePath);
                Logger.Debug("FilePath after ellipsis: " + filePath);
            }
            catch (ArgumentException)
            {
                Logger.Error(
                    "Autosave filepath is only a directory or the directory itself is already too long to append a filename under the limits of Windows (max "
                    + FileUtil.MAX_PATH + " characters): " + filePath);
                Cancel = true;
                return;
            }

            Job.OutputFilenameTemplate = filePath;
        }

        protected override bool QueryEmailSmtpPassword()
        {
            Job.Passwords.SmtpPassword = Job.Profile.EmailSmtp.Password;

            return true;
        }

        protected override bool QueryFtpPassword()
        {
            Job.Passwords.FtpPassword = Job.Profile.Ftp.Password;

            return true;
        }

        protected override bool QueryEncryptionPasswords()
        {
            Job.Passwords.PdfOwnerPassword = Job.Profile.PdfSettings.Security.OwnerPassword;
            Job.Passwords.PdfUserPassword = Job.Profile.PdfSettings.Security.UserPassword;

            return true;
        }

        protected override bool QuerySignaturePassword()
        {
            Job.Passwords.PdfSignaturePassword = Job.Profile.PdfSettings.Signature.SignaturePassword;

            return true;
        }

        protected override void NotifyUserAboutFailedJob()
        {
            // maybe do something here?
        }

        protected override bool EvaluateActionResult(ActionResult actionResult)
        {
            return actionResult.Success;
        }

        protected override void RetypeSmtpPassword(object sender, QueryPasswordEventArgs e)
        {
            Logger.Error("No retype smtp password event in auto save mode.");
            e.Cancel = true;
        }
    }
}