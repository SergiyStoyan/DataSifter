//********************************************************************************************
//Author: Sergey Stoyan, CliverSoft.com
//        http://cliversoft.com
//        stoyan@cliversoft.com
//        sergey.stoyan@gmail.com
//        17 February 2008
//Copyright: (C) 2008, Sergey Stoyan
//********************************************************************************************

using System;
using System.Text;
using System.Collections.Generic;
//using System.Threading;

namespace Cliver.DataSifter
{
    public partial class Settings
    {
        public static GeneralSettings General;
    }

    public class GeneralSettings : UserSettings
    {
        //public string ApplicationVersion;
        public string HelpFile = "DataSifter.chm";
        public string HelpFileUri = "http://www.cliversoft.com/products/regextreeer/2.5/help/index.htm";
        public bool CopySelectionToClipboard = true;
        public bool OutputGroupNames = true;
        public bool WrapText = true;
        public string OutputDataSeparator = @"
##################################
##################################
###
###
###
##################################
##################################
";
        public string SourceFormInitialDirectory;
        public Dictionary<string, string> FilterTypeNames2NewFilter;

        protected override void Loaded()
        {
            if (FilterTypeNames2NewFilter == null)
                FilterTypeNames2NewFilter = new Dictionary<string, string> { { "RegexFilter", ">(?'N'.*?)<\nIgnoreCase, Compiled, Singleline" } };
        }
    }
}
