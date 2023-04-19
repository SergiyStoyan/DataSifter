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
        public static HistorySettings History;
    }

    public class HistorySettings : UserSettings
    {
        public string LastSourceFile;
        public string LastFilterTreeFile;
        public List<string> OperatedFilterTypeNames = new List<string>();
        public System.Collections.Specialized.OrderedDictionary FilterTreeFolders2SourceFolder = new System.Collections.Specialized.OrderedDictionary();

        protected override void Loaded()
        {
        }
    }
}
