
using System.Collections.Generic;

namespace honyaku
{
    /// <summary>
    /// グローバル変数
    /// </summary>
    public class DataProperty
    {
        /// <summary>
        /// 言語識別データのディレクトリ
        /// </summary>
        public static readonly string TessDataFolder = "tessdata";

        /// <summary>
        /// 対応している言語
        /// </summary>
        public static List<Language> Languages = new List<Language>()
        {
            new Language("English", "英語", "en", "eng"),
            new Language("Japanese", "日本語", "ja", "jpn"),
        };
    }
}
