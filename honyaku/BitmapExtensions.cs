using System.Drawing;

namespace honyaku
{
    /// <summary>
    /// Bitmapクラスの拡張メソッド
    /// </summary>
    public static class BitmapExtensions
    {
        /// <summary>
        /// 光学文字認識による画像から文字列の読み出し
        /// </summary>
        /// <param name="bmp">元の画像</param>
        /// <param name="targetLanguageISO639_2">抽出する言語コード</param>
        /// <returns>抽出した文字列</returns>
        public static string ToOcrString(this Bitmap bmp, string targetLanguageISO639_2 = "eng")
        {
            using (var tesseract = new Tesseract.TesseractEngine(DataProperty.TessDataFolder, targetLanguageISO639_2))
            {
                return tesseract.Process(bmp).GetText().Trim();
            }
        }
    }
}
