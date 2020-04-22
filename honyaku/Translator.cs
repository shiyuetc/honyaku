using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace honyaku
{
    /// <summary>
    /// 翻訳クラス
    /// </summary>
    public static class Translator
    {
        /// <summary>
        /// 引数の文字列を指定した言語に翻訳する
        /// </summary>
        /// <param name="input">翻訳する文字列</param>
        /// <param name="sourceLanguage">翻訳前の言語</param>
        /// <param name="targetLanguage">翻訳後の言語</param>
        /// <returns>翻訳した文字列を返す</returns>
        public async static Task<string> Run(string input, string sourceLanguage = "en", string targetLanguage = "ja")
        {
            string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                sourceLanguage, targetLanguage, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = await httpClient.GetStringAsync(url);

            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData.Count > 0 ? jsonData[0] : null;
            string translation = "";

            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }

            if (translation.Length > 1) translation = translation.Substring(1);
            return translation;
        }
    }
}
