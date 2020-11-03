//********************************************************************************************
//Author: Sergey Stoyan, CliverSoft.com
//        http://cliversoft.com
//        stoyan@cliversoft.com
//        sergey.stoyan@gmail.com
//        17 February 2008
//Copyright: (C) 2008, Sergey Stoyan
//********************************************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cliver.DataSifter
{
    internal partial class SettingsForm : Form
    {
        internal SettingsForm()
        {
            InitializeComponent();
            Icon = Win.AssemblyRoutines.GetAppIcon();

            flagPrintParseLabels.Checked = Settings1.Appearance.PrintCaptureLabels;
            flagHighlightHtmlTags.Checked = Settings1.Appearance.HighlightHtmlTags;
            flagStripParsedTextInStatusBarFromHtmlTags.Checked = Settings1.Appearance.StripParsedTextInStatusBarFromHtmlTags;
            bHtmlTagsColor.ForeColor = Settings1.Appearance.HtmlTagsColor;
            bHtmlCommentColor.ForeColor = Settings1.Appearance.HtmlCommentColor;
            bHtmlJavascriptColor.ForeColor = Settings1.Appearance.HtmlJavascriptColor;
            flagCopySelectionToClipboard.Checked = Settings1.General.CopySelectionToClipboard;
            //HelpFileUri.Text = Settings.Default.HelpFileUri;

            label_colors = new List<Color>(Settings1.Appearance.FilterBackColors);
            fill_color_list();
        }

        void fill_color_list()
        {
            listBoxLabelColors.Items.Clear();
            int i = 0;
            foreach (Color c in label_colors)
            {
                listBoxLabelColors.Items.Add("level " + i.ToString());
                i++;
            }
        }
        List<Color> label_colors = new List<Color>();

        private void OK_Click(object sender, EventArgs e)
        {
            Settings1.Appearance.PrintCaptureLabels = flagPrintParseLabels.Checked;
            Settings1.Appearance.HighlightHtmlTags = flagHighlightHtmlTags.Checked;
            Settings1.Appearance.FilterBackColors = label_colors;
            Settings1.Appearance.HtmlTagsColor = bHtmlTagsColor.ForeColor;
            Settings1.Appearance.HtmlCommentColor = bHtmlCommentColor.ForeColor;
            Settings1.Appearance.HtmlJavascriptColor = bHtmlJavascriptColor.ForeColor;
            Settings1.Appearance.StripParsedTextInStatusBarFromHtmlTags = flagStripParsedTextInStatusBarFromHtmlTags.Checked;
            Settings1.General.CopySelectionToClipboard = flagCopySelectionToClipboard.Checked;
            //Settings.Default.HelpFileUri = HelpFileUri.Text;

            Settings.Default.Save();
            Settings.Default.Reload();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (!Message.YesNo("After resetting you cannot return back to your previous settings. Proceed?"))
                return;

            Settings.Default.Reset();
            Settings.Default.Reload();
        }

        private void flagPrintParseLabels_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Appearance.PrintCaptureLabels = flagPrintParseLabels.Checked;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutForm a = new AboutForm();
            a.ShowDialog();

        }

        private void StripParsedTextInStatucFromHtmlTags_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Appearance.StripParsedTextInStatusBarFromHtmlTags = flagStripParsedTextInStatusBarFromHtmlTags.Checked;
        }

        void listBoxLabelColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            using (Brush brush = new SolidBrush((Color)label_colors[e.Index]))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            using (Brush brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString((string)((ListBox)sender).Items[e.Index], e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void bAddColor_Click(object sender, EventArgs e)
        {
            int i = listBoxLabelColors.SelectedIndex;
            if (i < 0)
                i = listBoxLabelColors.Items.Count - 1;
            label_colors.Insert(i + 1, Color.Empty);
            fill_color_list();
        }

        private void bRemoveColor_Click(object sender, EventArgs e)
        {
            int i = listBoxLabelColors.SelectedIndex;
            if (i < 0)
                return;
            label_colors.RemoveAt(i);
            fill_color_list();
        }

        private void bEditColor_Click(object sender, EventArgs e)
        {
            int i = listBoxLabelColors.SelectedIndex;
            if (i < 0)
                return;
            ColorDialog d = new ColorDialog();
            d.Color = (Color)label_colors[i];
            if (d.ShowDialog(this) != DialogResult.OK)
                return;
            label_colors[i] = d.Color;
            fill_color_list();
        }

        private void listBoxLabelColors_DoubleClick(object sender, EventArgs e)
        {
            bEditColor_Click(null, null);
        }

        private void bHtmlTagsColor_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog(this) != DialogResult.OK)
                return;
            bHtmlTagsColor.ForeColor = d.Color;
        }

        private void bHtmlCommentColor_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog(this) != DialogResult.OK)
                return;
            bHtmlCommentColor.ForeColor = d.Color;
        }

        private void flagDisableBrowserWindow_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void bHtmlJavascriptColor_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog(this) != DialogResult.OK)
                return;
            bHtmlJavascriptColor.ForeColor = d.Color;
        }
    }
}