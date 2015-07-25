//********************************************************************************************
//Author: Sergey Stoyan, CliverSoft.com
//        http://cliversoft.com
//        stoyan@cliversoft.com
//        sergey.stoyan@gmail.com
//        17 February 2008
//Copyright: (C) 2008, Sergey Stoyan
//********************************************************************************************
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.Collections.Generic;

namespace Cliver.DataSifter {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
        
        public Settings() 
        {
            this.SettingsLoaded +=new System.Configuration.SettingsLoadedEventHandler(Settings_SettingsLoaded);
            this.SettingsSaving += new SettingsSavingEventHandler(Settings_SettingsSaving);
        }

        void Settings_SettingsLoaded(object sender, System.Configuration.SettingsLoadedEventArgs e)
        {
            try
            {
                if (Settings.Default.FilterMarkColorsRGB == null)
                    Settings.Default.FilterMarkColorsRGB = new int[] { };
                Settings.Default.FilterBackColors = convert_integers2Colors(Settings.Default.FilterMarkColorsRGB);
                if (Settings.Default.FilterBackColors.Length < 1)
                    Settings.Default.FilterBackColors = new Color[1] { Color.Red };

                if (Settings.Default._FilterTypeName2NewFilter == null)
                    Settings.Default._FilterTypeName2NewFilter = new System.Collections.Specialized.StringCollection();
                for (int i = 0; i < Settings.Default._FilterTypeName2NewFilter.Count; i += 2)
                    FilterTypeName2NewFilter[Settings.Default._FilterTypeName2NewFilter[i]] = Settings.Default._FilterTypeName2NewFilter[i + 1];
            }
            catch (Exception ex)
            {
                Message.Error(ex);
            }
        }

        public Dictionary<string, string> FilterTypeName2NewFilter = new Dictionary<string, string>();

        void Settings_SettingsSaving(object sender, CancelEventArgs e)
        {
            try
            {
                Settings.Default.FilterMarkColorsRGB = convert_Colors2integers(Settings.Default.FilterBackColors);

                Settings.Default._FilterTypeName2NewFilter.Clear();
                foreach (string type_name in FilterTypeName2NewFilter.Keys)
                {
                    Settings.Default._FilterTypeName2NewFilter.Add(type_name);
                    Settings.Default._FilterTypeName2NewFilter.Add(FilterTypeName2NewFilter[type_name]);
                }
            }
            catch (Exception ex)
            {
                Message.Error(ex);
            }
        }

        internal Color[] FilterBackColors = new Color[0];

        int[] convert_Colors2integers(Color[] colors)
        {
            int[] rgbs = new int[colors.Length];
            for (int i = 0; i < colors.Length; i++)
                rgbs[i] = colors[i].ToArgb();
            return rgbs;
        }

        Color[] convert_integers2Colors(int[] rgbs)
        {
            Color[] colors = new Color[rgbs.Length];
            for (int i = 0; i < rgbs.Length; i++)
                colors[i] = Color.FromArgb(rgbs[i]);
            return colors;
        }

        /// <summary>
        /// safely returns Color
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        internal Color GetFilterBackColor(int level)
        {
            level = level % FilterBackColors.Length;
            return FilterBackColors[level];
        }
    }
}
