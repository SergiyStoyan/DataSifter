namespace Cliver.DataSifter
{
    partial class JsonControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.JsonPathBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupName = new System.Windows.Forms.TextBox();
            this.TrimQuotation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // JsonPathBox
            // 
            this.JsonPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JsonPathBox.DetectUrls = false;
            this.JsonPathBox.EnableAutoDragDrop = true;
            this.JsonPathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JsonPathBox.Location = new System.Drawing.Point(0, 0);
            this.JsonPathBox.Name = "JsonPathBox";
            this.JsonPathBox.Size = new System.Drawing.Size(375, 42);
            this.JsonPathBox.TabIndex = 38;
            this.JsonPathBox.Text = "";
            this.JsonPathBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Output Name:";
            // 
            // GroupName
            // 
            this.GroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupName.Location = new System.Drawing.Point(381, 17);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(115, 20);
            this.GroupName.TabIndex = 40;
            // 
            // TrimQuotation
            // 
            this.TrimQuotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrimQuotation.AutoSize = true;
            this.TrimQuotation.Checked = true;
            this.TrimQuotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TrimQuotation.Location = new System.Drawing.Point(502, 4);
            this.TrimQuotation.Name = "TrimQuotation";
            this.TrimQuotation.Size = new System.Drawing.Size(95, 17);
            this.TrimQuotation.TabIndex = 41;
            this.TrimQuotation.Text = "Trim Quotation";
            this.TrimQuotation.UseVisualStyleBackColor = true;
            // 
            // JsonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.JsonPathBox);
            this.Controls.Add(this.TrimQuotation);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.label1);
            this.Name = "JsonControl";
            this.Size = new System.Drawing.Size(600, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox JsonPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupName;
        private System.Windows.Forms.CheckBox TrimQuotation;
    }
}
