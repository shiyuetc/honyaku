
namespace honyaku
{
    /// <summary>
    /// 言語クラス
    /// </summary>
    public struct Language
    {
        /// <summary>
        /// 英語名
        /// </summary>
        public string EnglishName { get; private set; }

        /// <summary>
        /// 日本語名
        /// </summary>
        public string JapaneseName { get; private set; }
        
        /// <summary>
        /// 言語コード ISO 639-1
        /// </summary>
        public string ISO639_1 { get; private set; }

        /// <summary>
        /// 言語コード ISO 639-2
        /// </summary>
        public string ISO639_2 { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="englishName">英語名</param>
        /// <param name="japaneseName">日本語名</param>
        /// <param name="iso639_1">言語コード ISO 639-1</param>
        /// <param name="iso639_2">言語コード ISO 639-2</param>
        public Language(string englishName, string japaneseName, string iso639_1, string iso639_2)
        {
            this.EnglishName = englishName;
            this.JapaneseName = japaneseName;
            this.ISO639_1 = iso639_1;
            this.ISO639_2 = iso639_2;
        }
    }
}
