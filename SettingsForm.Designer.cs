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
            this.tabSource = new System.Windows.Forms.TabPage();
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
            this.UserMarkColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bEditColor = new System.Windows.Forms.Button();
            this.bRemoveColor = new System.Windows.Forms.Button();
            this.bAddColor = new System.Windows.Forms.Button();
            this.listBoxLabelColors = new System.Windows.Forms.ListBox();
            this.BrowserFormSettings = new System.Windows.Forms.TabPage();
            this.StartWithBrowserWindow = new System.Windows.Forms.CheckBox();
            this.flagDisableBrowserWindow = new System.Windows.Forms.CheckBox();
            this.CaptureMarkColorInBrowser = new System.Windows.Forms.Button();
            this.tabCommon = new System.Windows.Forms.TabControl();
            this.tabSource.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.BrowserFormSettings.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(372, 272);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(372, 243);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(372, 196);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(372, 31);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 4;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Some settings being changed require restarting the application to get effect.";
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.tabControl2);
            this.tabSource.Location = new System.Drawing.Point(4, 22);
            this.tabSource.Name = "tabSource";
            this.tabSource.Size = new System.Drawing.Size(336, 242);
            this.tabSource.TabIndex = 4;
            this.tabSource.Text = "Source Window";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(336, 242);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flagCopySelectionToClipboard);
            this.tabPage3.Controls.Add(this.flagStripParsedTextInStatusBarFromHtmlTags);
            this.tabPage3.Controls.Add(this.flagHighlightHtmlTags);
            this.tabPage3.Controls.Add(this.flagPrintParseLabels);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(328, 216);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Preferences";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flagCopySelectionToClipboard
            // 
            this.flagCopySelectionToClipboard.AutoSize = true;
            this.flagCopySelectionToClipboard.Location = new System.Drawing.Point(6, 92);
            this.flagCopySelectionToClipboard.Name = "flagCopySelectionToClipboard";
            this.flagCopySelectionToClipboard.Size = new System.Drawing.Size(253, 17);
            this.flagCopySelectionToClipboard.TabIndex = 4;
            this.flagCopySelectionToClipboard.Text = "Automatically copy selected text to the clipboard";
            this.flagCopySelectionToClipboard.UseVisualStyleBackColor = true;
            // 
            // flagStripParsedTextInStatusBarFromHtmlTags
            // 
            this.flagStripParsedTextInStatusBarFromHtmlTags.AutoSize = true;
            this.flagStripParsedTextInStatusBarFromHtmlTags.Location = new System.Drawing.Point(6, 68);
            this.flagStripParsedTextInStatusBarFromHtmlTags.Name = "flagStripParsedTextInStatusBarFromHtmlTags";
            this.flagStripParsedTextInStatusBarFromHtmlTags.Size = new System.Drawing.Size(305, 17);
            this.flagStripParsedTextInStatusBarFromHtmlTags.TabIndex = 3;
            this.flagStripParsedTextInStatusBarFromHtmlTags.Text = "Strip capture text showed in the status bar from html entities";
            this.flagStripParsedTextInStatusBarFromHtmlTags.UseVisualStyleBackColor = true;
            // 
            // flagHighlightHtmlTags
            // 
            this.flagHighlightHtmlTags.AutoSize = true;
            this.flagHighlightHtmlTags.Location = new System.Drawing.Point(6, 45);
            this.flagHighlightHtmlTags.Name = "flagHighlightHtmlTags";
            this.flagHighlightHtmlTags.Size = new System.Drawing.Size(99, 17);
            this.flagHighlightHtmlTags.TabIndex = 2;
            this.flagHighlightHtmlTags.Text = "Tint html syntax";
            this.flagHighlightHtmlTags.UseVisualStyleBackColor = true;
            // 
            // flagPrintParseLabels
            // 
            this.flagPrintParseLabels.AutoSize = true;
            this.flagPrintParseLabels.Location = new System.Drawing.Point(6, 22);
            this.flagPrintParseLabels.Name = "flagPrintParseLabels";
            this.flagPrintParseLabels.Size = new System.Drawing.Size(116, 17);
            this.flagPrintParseLabels.TabIndex = 1;
            this.flagPrintParseLabels.Text = "Print capture labels";
            this.flagPrintParseLabels.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bHtmlJavascriptColor);
            this.tabPage4.Controls.Add(this.bHtmlCommentColor);
            this.tabPage4.Controls.Add(this.bHtmlTagsColor);
            this.tabPage4.Controls.Add(this.UserMarkColor);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.bEditColor);
            this.tabPage4.Controls.Add(this.bRemoveColor);
            this.tabPage4.Controls.Add(this.bAddColor);
            this.tabPage4.Controls.Add(this.listBoxLabelColors);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(328, 216);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Highlight Colors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bHtmlJavascriptColor
            // 
            this.bHtmlJavascriptColor.BackColor = System.Drawing.SystemColors.Window;
            this.bHtmlJavascriptColor.Location = new System.Drawing.Point(200, 110);
            this.bHtmlJavascriptColor.Name = "bHtmlJavascriptColor";
            this.bHtmlJavascriptColor.Size = new System.Drawing.Size(118, 23);
            this.bHtmlJavascriptColor.TabIndex = 9;
            this.bHtmlJavascriptColor.Text = "Html Javascript Color";
            this.bHtmlJavascriptColor.UseVisualStyleBackColor = false;
            this.bHtmlJavascriptColor.Click += new System.EventHandler(this.bHtmlJavascriptColor_Click);
            // 
            // bHtmlCommentColor
            // 
            this.bHtmlCommentColor.BackColor = System.Drawing.SystemColors.Window;
            this.bHtmlCommentColor.Location = new System.Drawing.Point(200, 81);
            this.bHtmlCommentColor.Name = "bHtmlCommentColor";
            this.bHtmlCommentColor.Size = new System.Drawing.Size(118, 23);
            this.bHtmlCommentColor.TabIndex = 6;
            this.bHtmlCommentColor.Text = "Html Comment Color";
            this.bHtmlCommentColor.UseVisualStyleBackColor = false;
            this.bHtmlCommentColor.Click += new System.EventHandler(this.bHtmlCommentColor_Click);
            // 
            // bHtmlTagsColor
            // 
            this.bHtmlTagsColor.BackColor = System.Drawing.SystemColors.Window;
            this.bHtmlTagsColor.Location = new System.Drawing.Point(200, 52);
            this.bHtmlTagsColor.Name = "bHtmlTagsColor";
            this.bHtmlTagsColor.Size = new System.Drawing.Size(118, 23);
            this.bHtmlTagsColor.TabIndex = 5;
            this.bHtmlTagsColor.Text = "Html Tag Color";
            this.bHtmlTagsColor.UseVisualStyleBackColor = false;
            this.bHtmlTagsColor.Click += new System.EventHandler(this.bHtmlTagsColor_Click);
            // 
            // UserMarkColor
            // 
            this.UserMarkColor.Location = new System.Drawing.Point(200, 21);
            this.UserMarkColor.Name = "UserMarkColor";
            this.UserMarkColor.Size = new System.Drawing.Size(118, 23);
            this.UserMarkColor.TabIndex = 4;
            this.UserMarkColor.Text = "User Mark Color";
            this.UserMarkColor.UseVisualStyleBackColor = true;
            this.UserMarkColor.Click += new System.EventHandler(this.UserMarkColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Back colors of parsed text:";
            // 
            // bEditColor
            // 
            this.bEditColor.Location = new System.Drawing.Point(90, 187);
            this.bEditColor.Name = "bEditColor";
            this.bEditColor.Size = new System.Drawing.Size(36, 23);
            this.bEditColor.TabIndex = 3;
            this.bEditColor.Text = "Edit";
            this.bEditColor.UseVisualStyleBackColor = true;
            this.bEditColor.Click += new System.EventHandler(this.bEditColor_Click);
            // 
            // bRemoveColor
            // 
            this.bRemoveColor.Location = new System.Drawing.Point(48, 187);
            this.bRemoveColor.Name = "bRemoveColor";
            this.bRemoveColor.Size = new System.Drawing.Size(36, 23);
            this.bRemoveColor.TabIndex = 2;
            this.bRemoveColor.Text = "-";
            this.bRemoveColor.UseVisualStyleBackColor = true;
            this.bRemoveColor.Click += new System.EventHandler(this.bRemoveColor_Click);
            // 
            // bAddColor
            // 
            this.bAddColor.Location = new System.Drawing.Point(6, 187);
            this.bAddColor.Name = "bAddColor";
            this.bAddColor.Size = new System.Drawing.Size(36, 23);
            this.bAddColor.TabIndex = 1;
            this.bAddColor.Text = "+";
            this.bAddColor.UseVisualStyleBackColor = true;
            this.bAddColor.Click += new System.EventHandler(this.bAddColor_Click);
            // 
            // listBoxLabelColors
            // 
            this.listBoxLabelColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxLabelColors.FormattingEnabled = true;
            this.listBoxLabelColors.Location = new System.Drawing.Point(6, 21);
            this.listBoxLabelColors.Name = "listBoxLabelColors";
            this.listBoxLabelColors.Size = new System.Drawing.Size(120, 160);
            this.listBoxLabelColors.TabIndex = 0;
            this.listBoxLabelColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLabelColors_DrawItem);
            this.listBoxLabelColors.DoubleClick += new System.EventHandler(this.listBoxLabelColors_DoubleClick);
            // 
            // BrowserFormSettings
            // 
            this.BrowserFormSettings.Controls.Add(this.StartWithBrowserWindow);
            this.BrowserFormSettings.Controls.Add(this.flagDisableBrowserWindow);
            this.BrowserFormSettings.Controls.Add(this.CaptureMarkColorInBrowser);
            this.BrowserFormSettings.Location = new System.Drawing.Point(4, 22);
            this.BrowserFormSettings.Name = "BrowserFormSettings";
            this.BrowserFormSettings.Padding = new System.Windows.Forms.Padding(3);
            this.BrowserFormSettings.Size = new System.Drawing.Size(336, 242);
            this.BrowserFormSettings.TabIndex = 0;
            this.BrowserFormSettings.Text = "Browser Window";
            this.BrowserFormSettings.UseVisualStyleBackColor = true;
            // 
            // StartWithBrowserWindow
            // 
            this.StartWithBrowserWindow.AutoSize = true;
            this.StartWithBrowserWindow.Location = new System.Drawing.Point(6, 19);
            this.StartWithBrowserWindow.Name = "StartWithBrowserWindow";
            this.StartWithBrowserWindow.Size = new System.Drawing.Size(150, 17);
            this.StartWithBrowserWindow.TabIndex = 2;
            this.StartWithBrowserWindow.Text = "Start with Browser window";
            this.StartWithBrowserWindow.UseVisualStyleBackColor = true;
            // 
            // flagDisableBrowserWindow
            // 
            this.flagDisableBrowserWindow.AutoSize = true;
            this.flagDisableBrowserWindow.Location = new System.Drawing.Point(6, 42);
            this.flagDisableBrowserWindow.Name = "flagDisableBrowserWindow";
            this.flagDisableBrowserWindow.Size = new System.Drawing.Size(141, 17);
            this.flagDisableBrowserWindow.TabIndex = 0;
            this.flagDisableBrowserWindow.Text = "Disable Browser window";
            this.flagDisableBrowserWindow.UseVisualStyleBackColor = true;
            this.flagDisableBrowserWindow.CheckedChanged += new System.EventHandler(this.flagDisableBrowserWindow_CheckedChanged_1);
            // 
            // CaptureMarkColorInBrowser
            // 
            this.CaptureMarkColorInBrowser.Location = new System.Drawing.Point(6, 85);
            this.CaptureMarkColorInBrowser.Name = "CaptureMarkColorInBrowser";
            this.CaptureMarkColorInBrowser.Size = new System.Drawing.Size(132, 23);
            this.CaptureMarkColorInBrowser.TabIndex = 1;
            this.CaptureMarkColorInBrowser.Text = "Parsed Match Color";
            this.CaptureMarkColorInBrowser.UseVisualStyleBackColor = true;
            this.CaptureMarkColorInBrowser.Click += new System.EventHandler(this.CaptureMarkColorInBrowser_Click);
            // 
            // tabCommon
            // 
            this.tabCommon.Controls.Add(this.BrowserFormSettings);
            this.tabCommon.Controls.Add(this.tabSource);
            this.tabCommon.Location = new System.Drawing.Point(12, 31);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.SelectedIndex = 0;
            this.tabCommon.Size = new System.Drawing.Size(344, 268);
            this.tabCommon.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.tabCommon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "DataSifter Settings";
            this.Activated += new System.EventHandler(this.SettingsForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.tabSource.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.BrowserFormSettings.ResumeLayout(false);
            this.BrowserFormSettings.PerformLayout();
            this.tabCommon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox flagStripParsedTextInStatusBarFromHtmlTags;
        private System.Windows.Forms.CheckBox flagHighlightHtmlTags;
        private System.Windows.Forms.CheckBox flagPrintParseLabels;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bHtmlCommentColor;
        private System.Windows.Forms.Button bHtmlTagsColor;
        private System.Windows.Forms.Button UserMarkColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bEditColor;
        private System.Windows.Forms.Button bRemoveColor;
        private System.Windows.Forms.Button bAddColor;
        private System.Windows.Forms.ListBox listBoxLabelColors;
        private System.Windows.Forms.TabPage BrowserFormSettings;
        private System.Windows.Forms.CheckBox flagDisableBrowserWindow;
        private System.Windows.Forms.Button CaptureMarkColorInBrowser;
        private System.Windows.Forms.TabControl tabCommon;
        private System.Windows.Forms.CheckBox flagCopySelectionToClipboard;
        private System.Windows.Forms.Button bHtmlJavascriptColor;
        private System.Windows.Forms.CheckBox StartWithBrowserWindow;
    }
}