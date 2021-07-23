//********************************************************************************************
//Author: Sergey Stoyan, CliverSoft.com
//        http://cliversoft.com
//        stoyan@cliversoft.com
//        sergey.stoyan@gmail.com
//        17 February 2008
//Copyright: (C) 2008, Sergey Stoyan
//********************************************************************************************
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Cliver.DataSifter
{
    static class Program
    {
        static Program()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += delegate (object sender, UnhandledExceptionEventArgs args)
            {
                Exception e = (Exception)args.ExceptionObject;
                Log.Error(e);
                if (e.InnerException != null)
                    Message.Error("UnhandledException", e.InnerException);
                else
                    Message.Error(e);
                Environment.Exit(0);
            };

            //SetProcessDpiAwareness((int)DpiAwareness.PerMonitorAware);

            AssemblyRoutines.AssemblyInfo ai = new AssemblyRoutines.AssemblyInfo();
            Name = ai.Product;
            Version = ai.Version;
            FullVersion = Version.ToString(3);
            FullName = Name + " " + FullVersion;

            Message.TopMost = true;
            Win.LogMessage.DisableStumblingDialogs = false;
            //Win.LogMessage.ShowDialog = ((string title, Icon icon, string message, string[] buttons, int default_button, Form owner) => { return Message.ShowDialog(title, icon, message, buttons, default_button, owner); });

            Config.Reload();

            Log.Initialize(Log.Mode.ONE_FOLDER, new System.Collections.Generic.List<string> { Log.CompanyUserDataDir });
        }

        public static readonly string Name;
        public static readonly Version Version;
        public static readonly string FullName;
        public static readonly string FullVersion;

        [STAThread]
        static void Main(string [] args)
        {
            try
            {
                Message.TopMost = true;
                Win.LogMessage.DisableStumblingDialogs = false;

                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                
                Application.Run(SourceForm.This);

                Config.Save();
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
                if (File.Exists(AppDir + Settings.General.HelpFile))
                    Process.Start(Settings.General.HelpFile);
                else
                    Process.Start(Settings.General.HelpFileUri);
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