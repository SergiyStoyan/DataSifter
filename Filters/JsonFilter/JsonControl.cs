using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliver.DataSifter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class JsonControl : FilterControl
    {
        /// <summary>
        /// needed for VS designer
        /// </summary>
        public JsonControl()
        {
            InitializeComponent();
        }

        internal JsonControl(JsonFilter filter)
            : base(filter)
        {
            InitializeComponent();

            JsonPathBox.Text = filter.JsonPath;
            GroupName.Text = filter.GroupName;
            TrimQuotation.Checked = filter.TrimQuotation;
        }

        override internal string GetUpdatedFilterDefinition()
        {
            //validate
            //HtmlAgilityPack.HtmlDocument d = new HtmlAgilityPack.HtmlDocument();
            //d.LoadHtml("<html></html>");
            //HtmlAgilityPack.HtmlNodeCollection nc = d.DocumentNode.SelectNodes(JsonPathBox.Text);
            
            return JsonPathBox.Text + "\n" + GroupName.Text + "\n" + TrimQuotation.Checked;
        }
    }
}