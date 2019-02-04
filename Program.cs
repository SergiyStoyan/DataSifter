//********************************************************************************************
//Author: Sergey Stoyan, CliverSoft.com
//        http://cliversoft.com
//        stoyan@cliversoft.com
//        sergey.stoyan@gmail.com
//        17 February 2008
//Copyright: (C) 2008, Sergey Stoyan
//********************************************************************************************
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Text.RegularExpressions;

namespace Cliver.DataSifter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            try
            {
                Message.TopMost = true;
                LogMessage.DisableStumblingDialogs = false;
                LogMessage.ShowDialog = ((string title, System.Drawing.Icon icon, string message, string[] buttons, int default_button, Form owner) => { return Message.ShowDialog(title, icon, message, buttons, default_button, owner); });
                Log.ShowDeleteOldLogsDialog = false;
                Log.Initialize(Log.Mode.ONLY_LOG, Log.CompanyCommonDataDir, true);

                Settings.Default.Reload();
                if (Settings.Default.ApplicationVersion != Application.ProductVersion)
                {
                    //string HelpFileUri = Settings.Default.HelpFileUri;
                    Settings.Default.Upgrade();
                    //Settings.Default.HelpFileUri = HelpFileUri;
                    Settings.Default.ApplicationVersion = Application.ProductVersion;
                    Settings.Default.Save();
                }

                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                
                Application.Run(SourceForm.This);

                Settings.Default.Save();
            }
            catch (Exception e)
            {
                Message.Error(e);
            }
        }

        //static readonly internal System.Windows.Forms.ToolTip ToolTip = new ToolTip();
        
        static readonly internal string AppTitle = Application.ProductName;

        static readonly internal string Title = AppTitle;

        static Program()
        {
            Application.ThreadException += delegate (object sender, System.Threading.ThreadExceptionEventArgs e)
            {
                Message.Error(e.Exception);
            };
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += delegate (object sender, UnhandledExceptionEventArgs e)
            {
                if (e.IsTerminating || e.ExceptionObject is ThreadAbortException)
                    return;
                if (e.ExceptionObject is Exception)
                    Message.Error((Exception)e.ExceptionObject);
            };

            try
            {
                AssemblyName ean = Assembly.GetEntryAssembly().GetName();
                AppTitle = ean.Name;
                if (ean.Version.Major > 0 || ean.Version.Minor > 0)
                    AppTitle += ean.Version.Major + "." + ean.Version.Minor;
            }
            catch (Exception e)
            {
                Message.Error(e);
            }
        }

        static internal void Help()
        {
            try
            {
                if (File.Exists(AppDir + Settings.Default.HelpFile))
                    Process.Start(Settings.Default.HelpFile);
                else
                    Process.Start(Settings.Default.HelpFileUri);
            }
            catch (Exception ex)
            {
                Message.Error(ex);
            }
        }

        static internal string AppDir = Application.StartupPath + "\\";

        internal const string FilterTreeFileExtension = "fltr";
    }
}