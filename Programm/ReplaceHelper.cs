using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public class ReplaceHelper
    {
        public string textOriginal { get; set; } = "";
        string clearedText;

        public ReplaceHelper(string textOriginal)
        {
            this.textOriginal = textOriginal;
        }

        public ReplaceHelper() { }

        // Возвращаем текст, в котором мы меняем трёхбуквенные слова на символ, кодом которого является среднее арифмитическое букв трёхбуквенного слова
        public string getReplacedText()
        {
            string[] thirdArray = getThirdWordsArray();
            Dictionary<string, char> wordsMap = getHashMapWordCode(thirdArray);

            string replacedText = textOriginal;

            foreach (string key in wordsMap.Keys)
            {
                Console.WriteLine(key + ":" + wordsMap[key]);
                replacedText = replacedText.Replace(key, wordsMap[key].ToString());
            }

            return replacedText;
        }

        //Получаем массив строк из слов длина которых == 3 из предварительно очищенного текста
        public string[] getThirdWordsArray()
        {
            return getClearedText().Split(' ').Where(word => word.Length == 3).ToArray();
        }

        //Получаем ассоциативный массив где ключ это слово из трёх букв, а значение это среднее арифмитическое из кода букв ключа.
        public Dictionary<string, char> getHashMapWordCode(string[] thirdArray)
        {
            Dictionary<string, char> wordsCodeMap = new Dictionary<string, char>();
            foreach (string word in thirdArray)
            {
                if (!wordsCodeMap.ContainsKey(word))
                {
                    wordsCodeMap.Add(word, getAvgWordCode(word));
                }
            }
            return wordsCodeMap;
        }

        //Получаем среднее арифмитеческое кода букв трёзбуквенного слова
        public char getAvgWordCode(String word)
        {
            int code = word[0] + word[1] + word[2];
            return (char)(code / 3);
        }

        //Получаем очищенный первоначальный текст от спец символов, чтобы слова типа тр! ла" лф; не засчитывались за трёхбуквенные
        public string getClearedText()
        {
            return textOriginal.Replace("“", "")
               .Replace("'", "").Replace("\"", "")
               .Replace(".", "").Replace(",", "")
               .Replace("!", "").Replace("?", "")
               .Replace(":", "").Replace(";", "");
        }
    }
}
