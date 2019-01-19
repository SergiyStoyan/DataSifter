namespace Cliver.DataSifter
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flagCopySelectionToClipboard = new System.Windows.Forms.CheckBox();
            this.flagStripParsedTextInStatusBarFromHtmlTags = new System.Windows.Forms.CheckBox();
            this.flagHighlightHtmlTags = new System.Windows.Forms.CheckBox();
            this.flagPrintParseLabels = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bHtmlJavascriptColor = new System.Windows.Forms.Button();
            this.bHtmlCommentColor = new System.Windows.Forms.Button();
            this.bHtmlTagsColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bEditColor = new System.Windows.Forms.Button();
            this.bRemoveColor = new System.Windows.Forms.Button();
            this.bAddColor = new System.Windows.Forms.Button();
            this.listBoxLabelColors = new System.Windows.Forms.ListBox();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(992, 649);
            this.Cancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(200, 55);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(992, 579);
            this.OK.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(200, 55);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(992, 467);
            this.Reset.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(200, 55);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(992, 74);
            this.About.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(200, 55);
            this.About.TabIndex = 4;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(968, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Some settings being changed require restarting the application to get effect.";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(32, 74);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(944, 639);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flagCopySelectionToClipboard);
            this.tabPage3.Controls.Add(this.flagStripParsedTextInStatusBarFromHtmlTags);
            this.tabPage3.Controls.Add(this.flagHighlightHtmlTags);
            this.tabPage3.Controls.Add(this.flagPrintParseLabels);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Size = new System.Drawing.Size(924, 581);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Preferences";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flagCopySelectionToClipboard
            // 
            this.flagCopySelectionToClipboard.AutoSize = true;
            this.flagCopySelectionToClipboard.Location = new System.Drawing.Point(16, 219);
            this.flagCopySelectionToClipboard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flagCopySelectionToClipboard.Name = "flagCopySelectionToClipboard";
            this.flagCopySelectionToClipboard.Size = new System.Drawing.Size(660, 36);
            this.flagCopySelectionToClipboard.TabIndex = 4;
            this.flagCopySelectionToClipboard.Text = "Automatically copy selected text to the clipboard";
            this.flagCopySelectionToClipboard.UseVisualStyleBackColor = true;
            // 
            // flagStripParsedTextInStatusBarFromHtmlTags
            // 
            this.flagStripParsedTextInStatusBarFromHtmlTags.AutoSize = true;
            this.flagStripParsedTextInStatusBarFromHtmlTags.Location = new System.Drawing.Point(16, 162);
            this.flagStripParsedTextInStatusBarFromHtmlTags.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flagStripParsedTextInStatusBarFromHtmlTags.Name = "flagStripParsedTextInStatusBarFromHtmlTags";
            this.flagStripParsedTextInStatusBarFromHtmlTags.Size = new System.Drawing.Size(803, 36);
            this.flagStripParsedTextInStatusBarFromHtmlTags.TabIndex = 3;
            this.flagStripParsedTextInStatusBarFromHtmlTags.Text = "Strip capture text showed in the status bar from html entities";
            this.flagStripParsedTextInStatusBarFromHtmlTags.UseVisualStyleBackColor = true;
            // 
            // flagHighlightHtmlTags
            // 
            this.flagHighlightHtmlTags.AutoSize = true;
            this.flagHighlightHtmlTags.Location = new System.Drawing.Point(16, 107);
            this.flagHighlightHtmlTags.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flagHighlightHtmlTags.Name = "flagHighlightHtmlTags";
            this.flagHighlightHtmlTags.Size = new System.Drawing.Size(251, 36);
            this.flagHighlightHtmlTags.TabIndex = 2;
            this.flagHighlightHtmlTags.Text = "Tint html syntax";
            this.flagHighlightHtmlTags.UseVisualStyleBackColor = true;
            // 
            // flagPrintParseLabels
            // 
            this.flagPrintParseLabels.AutoSize = true;
            this.flagPrintParseLabels.Location = new System.Drawing.Point(16, 52);
            this.flagPrintParseLabels.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flagPrintParseLabels.Name = "flagPrintParseLabels";
            this.flagPrintParseLabels.Size = new System.Drawing.Size(297, 36);
            this.flagPrintParseLabels.TabIndex = 1;
            this.flagPrintParseLabels.Text = "Print capture labels";
            this.flagPrintParseLabels.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bHtmlJavascriptColor);
            this.tabPage4.Controls.Add(this.bHtmlCommentColor);
            this.tabPage4.Controls.Add(this.bHtmlTagsColor);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.bEditColor);
            this.tabPage4.Controls.Add(this.bRemoveColor);
            this.tabPage4.Controls.Add(this.bAddColor);
            this.tabPage4.Controls.Add(this.listBoxLabelColors);
            this.tabPage4.Location = new System.Drawing.Point(10, 48);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage4.Size = new System.Drawing.Size(924, 581);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Highlight Colors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bHtmlJavascriptColor
            // 
            this.bHtmlJavascriptColor.BackColor = System.Drawing.SystemColors.Window;
            this.bHtmlJavascriptColor.Location = new System.Drawing.Point(531, 219);
            this.bHtmlJavascriptColor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bHtmlJavascriptColor.Name = "bHtmlJavascriptColor";
            this.bHtmlJavascriptColor.Size = new System.Drawing.Size(315, 55);
            this.bHtmlJavascriptColor.TabIndex = 9;
            this.bHtmlJavascriptColor.Text = "Html Javascript Color";
            this.bHtmlJavascriptColor.UseVisualStyleBackColor = false;
            // 
            // bHtmlCommentColor
            // 
            this.bHtmlCommentColor.BackColor = System.Drawing.SystemColors.Window;
            this.bHtmlCommentColor.Location = new System.Drawing.Point(531, 150);
            this.bHtmlCommentColor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bHtmlCommentColor.Name = "bHtmlCommentColor";
            this.bHtmlCommentColor.Size = new System.Drawing.Size(315, 55);
            this.bHtmlCommentColor.TabIndex = 6;
            this.bHtmlCommentColor.Text = "Html Comment Color";
            this.bHtmlCommentColor.UseVisualStyleBackColor = false;
            // 
            // bHtmlTagsColor
            // 
            this.bHtmlTagsColor.BackColor = System.Drawing.SystemColors.Window;
            this.bHtmlTagsColor.Location = new System.Drawing.Point(531, 81);
            this.bHtmlTagsColor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bHtmlTagsColor.Name = "bHtmlTagsColor";
            this.bHtmlTagsColor.Size = new System.Drawing.Size(315, 55);
            this.bHtmlTagsColor.TabIndex = 5;
            this.bHtmlTagsColor.Text = "Html Tag Color";
            this.bHtmlTagsColor.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Back colors of parsed text:";
            // 
            // bEditColor
            // 
            this.bEditColor.Location = new System.Drawing.Point(240, 482);
            this.bEditColor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bEditColor.Name = "bEditColor";
            this.bEditColor.Size = new System.Drawing.Size(96, 55);
            this.bEditColor.TabIndex = 3;
            this.bEditColor.Text = "Edit";
            this.bEditColor.UseVisualStyleBackColor = true;
            // 
            // bRemoveColor
            // 
            this.bRemoveColor.Location = new System.Drawing.Point(128, 482);
            this.bRemoveColor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bRemoveColor.Name = "bRemoveColor";
            this.bRemoveColor.Size = new System.Drawing.Size(96, 55);
            this.bRemoveColor.TabIndex = 2;
            this.bRemoveColor.Text = "-";
            this.bRemoveColor.UseVisualStyleBackColor = true;
            // 
            // bAddColor
            // 
            this.bAddColor.Location = new System.Drawing.Point(16, 482);
            this.bAddColor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bAddColor.Name = "bAddColor";
            this.bAddColor.Size = new System.Drawing.Size(96, 55);
            this.bAddColor.TabIndex = 1;
            this.bAddColor.Text = "+";
            this.bAddColor.UseVisualStyleBackColor = true;
            // 
            // listBoxLabelColors
            // 
            this.listBoxLabelColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxLabelColors.FormattingEnabled = true;
            this.listBoxLabelColors.Location = new System.Drawing.Point(16, 81);
            this.listBoxLabelColors.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBoxLabelColors.Name = "listBoxLabelColors";
            this.listBoxLabelColors.Size = new System.Drawing.Size(313, 368);
            this.listBoxLabelColors.TabIndex = 0;
            this.listBoxLabelColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLabelColors_DrawItem);
            this.listBoxLabelColors.DoubleClick += new System.EventHandler(this.listBoxLabelColors_DoubleClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 742);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "DataSifter Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox flagCopySelectionToClipboard;
        private System.Windows.Forms.CheckBox flagStripParsedTextInStatusBarFromHtmlTags;
        private System.Windows.Forms.CheckBox flagHighlightHtmlTags;
        private System.Windows.Forms.CheckBox flagPrintParseLabels;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bHtmlJavascriptColor;
        private System.Windows.Forms.Button bHtmlCommentColor;
        private System.Windows.Forms.Button bHtmlTagsColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bEditColor;
        private System.Windows.Forms.Button bRemoveColor;
        private System.Windows.Forms.Button bAddColor;
        private System.Windows.Forms.ListBox listBoxLabelColors;
    }
}