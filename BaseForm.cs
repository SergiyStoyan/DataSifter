using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliver.DataSifter
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        delegate void _set_control_text(Control c, string m);
        _set_control_text _set_control_text_delegate;
        protected void set_control_text(Control c, string m)
        {
            if (c.InvokeRequired)
            {
                _set_control_text_delegate = new _set_control_text(set_control_text);
                this.BeginInvoke(_set_control_text_delegate, new object[] { c, m });
            }
            else
                c.Text = m;
        }

        //protected void set_control_text(Control c, string m)
        //{
        //    if (c.InvokeRequired)
        //        this.BeginInvoke(new MethodInvoker(() => { c.Text = m; }));
        //}

        protected void invoke_in_hosting_thread(MethodInvoker code)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(code);
                return;
            }
            code.Invoke();
        }

        protected void begin_invoke_in_hosting_thread(MethodInvoker code)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(code);
                return;
            }
            code.Invoke();
        }
    }
}
