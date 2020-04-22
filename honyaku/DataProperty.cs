
using System.Collections.Generic;

namespace honyaku
{
    /// <summary>
    /// グローバル変数
    /// </summary>
    public class DataProperty
    {
        public static readonly string TessDataFolder = "tessdata";

        public static List<Language> Languages = new List<Language>()
        {
            new Language("English", "英語", "en", "eng"),
            new Language("Japanese", "日本語", "ja", "jpn"),
        };
    }
}
