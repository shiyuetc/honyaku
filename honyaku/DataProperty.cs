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
        
        public static bool ExistTessData(string Tess)
        {
            return System.IO.File.Exists(DataProperty.TessDataFolder + "/" + Tess + ".traineddata");
        }

        /// <summary>
        /// 配置データのファイルパス
        /// </summary>
        public static readonly string PlacesFile = "Places.xml";

        /// <summary>
        /// 対応している言語
        /// </summary>
        public static readonly Dictionary<string, Language> Languages = new Dictionary<string, Language>()
        {
            { "english", new Language("English", "英語", "en", "eng") },
            { "japanese", new Language("Japanese", "日本語", "ja", "jpn") },
        };
    }
}
