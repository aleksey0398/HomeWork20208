using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonReplace_Click(object sender, EventArgs e)
        {
            textBoxReplaced.Text = getReplacedText();
        }

        // Возвращаем текст, в котором мы меняем трёхбуквенные слова на символ, кодом которого является среднее арифмитическое букв трёхбуквенного слова
        private string getReplacedText()
        {
            Dictionary<string, char> wordsMap = getHashMapWordCode();

            string replacedText = textBoxOriginal.Text;

            foreach (string key in wordsMap.Keys)
            {
                Console.WriteLine(key + ":" + wordsMap[key]);
                replacedText = replacedText.Replace(key, wordsMap[key].ToString());
            }

            return replacedText;
        }

        //Получаем массив строк из слов длина которых == 3 из предваретильно очищенного текста
        private string[] getThirdWordsArray()
        {
            return getClearedText().Split(' ').Where(word => word.Length == 3).ToArray();
        }

        //Получаем ассоциативный массив где ключ это слово из трёх букв, а значение это среднее арифмитическое из кода букв ключа.
        private Dictionary<string, char> getHashMapWordCode()
        {
            Dictionary<string, char> wordsCodeMap = new Dictionary<string, char>();
            foreach (string word in getThirdWordsArray())
            {
                if (!wordsCodeMap.ContainsKey(word))
                {
                    wordsCodeMap.Add(word, getAvgWordCode(word));
                }
            }
            return wordsCodeMap;
        }

        //Получаем среднее арифмитеческое код букв трёзбуквенного слова
        private char getAvgWordCode(String word)
        {
            int code = word[0] + word[1] + word[2];
            return (char)(code / 3);
        }

        //Получаем очищенный первоначальный текст от спец символов, чтобы слова типа тр! ла" лф; не засчитывались за трёхбуквенные
        private string getClearedText()
        {
            string tmp = textBoxOriginal.Text.Replace("“", "")
                .Replace("'", "").Replace("\"", "")
                .Replace(".", "").Replace(",", "")
                .Replace("!", "").Replace("?", "")
                .Replace(":", "").Replace(";", "");
            Console.WriteLine(tmp);
            return tmp;
        }
    }
}
