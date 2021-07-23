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
using System.Drawing;

namespace Cliver.DataSifter
{
    public partial class Settings
    {
        public static AppearanceSettings Appearance;
    }

    public class AppearanceSettings : UserSettings
    {
        public bool HighlightHtmlTags = true;
        public bool PrintCaptureLabels = true;
        public Color HtmlTagsColor = Color.IndianRed;
        public Color HtmlCommentColor = Color.DarkCyan;
        public Color FilterCommentColor = Color.MidnightBlue;
        public Color FilterGroupNameColor = Color.FromArgb(192, 0, 0);
        public Color HtmlJavascriptColor = Color.MidnightBlue;
        public Font CaptureLabelFont = new Font("Arial", 6.75f, FontStyle.Bold, GraphicsUnit.Point);
        public bool StripParsedTextInStatusBarFromHtmlTags = true;
        public List<Color> FilterBackColors;

        /// <summary>
        /// safely returns Color
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        internal Color GetFilterBackColor(int level)
        {
            level = level % FilterBackColors.Count;
            return FilterBackColors[level];
        }

        protected override void Loaded()
        {
            if (FilterBackColors == null || FilterBackColors.Count < 1)
                FilterBackColors = new List<Color> {
                    Color.FromArgb(200, 200, 255),
                    Color.FromArgb(255,182,193),
                    Color .FromArgb(144, 238, 144),
                    Color.FromArgb(255, 165, 74),
                    Color.FromArgb(230, 230, 0),
                    Color.FromArgb(255, 0, 255),
                    Color.FromArgb(0, 255, 255),
                    Color.FromArgb(128,255, 0),
                    Color.FromArgb(192,192, 192),
                    Color.FromArgb(128,128, 64),
                    Color.FromArgb(255,0, 128),
                    Color.FromArgb(0, 255, 128),
                    Color.FromArgb(0, 128, 255),
                    Color.FromArgb(255, 0, 255),
                    Color.FromArgb(64, 128, 128),
                    Color.FromArgb(231, 112, 24),
                    Color.FromArgb(255, 255, 0),
                    Color.FromArgb(128, 0, 128),
                    Color.FromArgb(0, 128, 128),
                    Color.FromArgb(0, 0, 255),
                    Color.FromArgb(255, 0, 0)
                };
        }
    }
}
