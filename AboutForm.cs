//********************************************************************************************
//Author: Sergey Stoyan
//        sergey.stoyan@gmail.com
//        sergey_stoyan@yahoo.com
//        http://www.cliversoft.com
//        26 September 2006
//Copyright: (C) 2006, Sergey Stoyan
//********************************************************************************************
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Cliver.DataSifter
{
	/// <summary>
	/// Summary description for About.
	/// </summary>
	internal class AboutForm : BaseForm
	{
		private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel4;
        private Label label1;
        private LinkLabel linkLabel5;
        private Label lProduct;
        private PictureBox pIcon;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        internal AboutForm()
		{
			//
			// Required for Windows Form Designer support
			//
            InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lAuthor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.lProduct = new System.Windows.Forms.Label();
            this.pIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Location = new System.Drawing.Point(58, 62);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(250, 13);
            this.lAuthor.TabIndex = 15;
            this.lAuthor.Text = "Copyright: (C) 2006-2008, Sergey Stoyan, CliverSoft";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.close);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(58, 79);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.cliversoft.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(58, 120);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(130, 13);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "sergey.stoyan@gmail.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(58, 102);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(114, 13);
            this.linkLabel4.TabIndex = 23;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "stoyan@cliversoft.com";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "This application contains HtmlEditor control developed by Tim Anderson.";
            // 
            // linkLabel5
            // 
            this.linkLabel5.Location = new System.Drawing.Point(58, 185);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(235, 21);
            this.linkLabel5.TabIndex = 25;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "http://itwriting.com/htmleditor/index.php";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // lProduct
            // 
            this.lProduct.AutoSize = true;
            this.lProduct.Location = new System.Drawing.Point(115, 31);
            this.lProduct.Name = "lProduct";
            this.lProduct.Size = new System.Drawing.Size(69, 13);
            this.lProduct.TabIndex = 26;
            this.lProduct.Text = "DataSifter";
            // 
            // pIcon
            // 
            this.pIcon.Image = ((System.Drawing.Image)(resources.GetObject("pIcon.Image")));
            this.pIcon.Location = new System.Drawing.Point(61, 12);
            this.pIcon.Name = "pIcon";
            this.pIcon.Size = new System.Drawing.Size(16, 16);
            this.pIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pIcon.TabIndex = 27;
            this.pIcon.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(405, 256);
            this.Controls.Add(this.pIcon);
            this.Controls.Add(this.lProduct);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void About_Load(object sender, System.EventArgs e)
        {
            //lProduct.Text = ((AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute))).Product +
              //  ", " + ((AssemblyVersionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyVersionAttribute))).Version;
            
            AssemblyName an = Assembly.GetExecutingAssembly().GetName();
            lProduct.Text = an.Name + " " + an.Version;

            lAuthor.Text = ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute))).Copyright +
                ", " + ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute))).Company; 		
		}

		private void close(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://cliversoft.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:sergey.stoyan@gmail.com");            
        }

        //private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Process.Start("mailto:sergey_stoyan@yahoo.com");                 
        //}

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:stoyan@cliversoft.com");            
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://itwriting.com/htmleditor/index.php");
        }
	}
}
