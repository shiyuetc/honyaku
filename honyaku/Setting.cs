using System.Collections.Generic;
using System.Drawing;

namespace honyaku
{
    /// <summary>
    /// 設定情報を保持するクラス
    /// </summary>
    public static class Setting
    {
        /// <summary>
        /// 設定を変数に読み込む
        /// </summary>
        public static void Load()
        {
            Setting.SourceLanguage = Properties.Settings.Default["SourceLanguage"].ToString();
            Setting.TargetLanguage = Properties.Settings.Default["TargetLanguage"].ToString();
            Setting.BackPlace = (bool)Properties.Settings.Default["BackPlace"];
            Setting.BackPlaceLocation = (Point)Properties.Settings.Default["BackPlaceLocation"];
            Setting.BackPlaceSize = (Size)Properties.Settings.Default["BackPlaceSize"];
            Setting.ReturnFocus = (bool)Properties.Settings.Default["ReturnFocus"];

            Setting.CaptureRegionMargin = (int)Properties.Settings.Default["CaptureRegionMargin"];
            Setting.CaptureRegionVisible = (bool)Properties.Settings.Default["CaptureRegionVisible"];
            Setting.CaptureRegionColor = (Color)Properties.Settings.Default["CaptureRegionColor"];
            Setting.CaptureSave = (bool)Properties.Settings.Default["CaptureSave"];

            Setting.ResultFont = (Font)Properties.Settings.Default["ResultFont"];
        }

        /// <summary>
        /// 変数から設定に保存
        /// </summary>
        public static void Save()
        {
            Properties.Settings.Default["SourceLanguage"] = Setting.SourceLanguage;
            Properties.Settings.Default["TargetLanguage"] = Setting.TargetLanguage;
            Properties.Settings.Default["BackPlace"] = Setting.BackPlace;
            Properties.Settings.Default["BackPlaceLocation"] = Setting.BackPlaceLocation;
            Properties.Settings.Default["BackPlaceSize"] = Setting.BackPlaceSize;
            Properties.Settings.Default["ReturnFocus"] = Setting.ReturnFocus;
            
            Properties.Settings.Default["CaptureRegionMargin"] = Setting.CaptureRegionMargin;
            Properties.Settings.Default["CaptureRegionVisible"] = Setting.CaptureRegionVisible;
            Properties.Settings.Default["CaptureRegionColor"] = Setting.CaptureRegionColor;
            Properties.Settings.Default["CaptureSave"] = Setting.CaptureSave;

            Properties.Settings.Default["ResultFont"] = Setting.ResultFont;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 引数から設定に保存
        /// </summary>
        /// <param name="settings">設定データのコレクション</param>
        public static void Save(Dictionary<string, object> settings)
        {
            foreach (KeyValuePair<string, object> setting in settings)
            {
                Properties.Settings.Default[setting.Key] = setting.Value;
            }
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 
        /// </summary>
        public static string SourceLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string TargetLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static bool BackPlace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static Point BackPlaceLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static Size BackPlaceSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static bool ReturnFocus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static bool CaptureSave { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static int CaptureRegionMargin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static bool CaptureRegionVisible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static Color CaptureRegionColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static Font ResultFont { get; set; }

    }
}
