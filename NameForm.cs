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

namespace Cliver.DataSifter
{
    /// <summary>
    /// asks for name for the newly saved prepared filter tree
    /// </summary>
    internal partial class NameForm : Form
    {
        internal NameForm(string default_file_name)
        {
            InitializeComponent();
            Icon = Win.AssemblyRoutines.GetAppIcon();

            this.Text = Program.FullName;
            boxName.Text = default_file_name;
        }

        internal string FileName = "";

        private void OK_Click(object sender, EventArgs e)
        {            
            FileName = boxName.Text;
            if (string.IsNullOrEmpty(FileName))
                return;
            this.Close();
        }
    }
}