using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm.Tests
{
    [TestClass()]
    public class ReplaceHelperTests
    {
        string textForTesting = "Создание тестового Создание тестового класса, чтобы проверить класс BankAccount." +
            "Можно использовать UnitTest1.cs, созданный в шаблоне проекта, но луч! дать файлу и классу более описательные именаПереименуйте файл и " +
            "Чтобы переименовать файл, в обо решений выберите файл UnitTest1.cs в проекте BankTests. " +
            "В контекстном меню выберите команду Переименовать, а затем переименуйте файл в BankAccountTests.cs." +
            "Чтобы переименовать класс, поместите курсор в UnitTest1 в редакторе кода, щелкните правой кнопкой мыши и выберите команду Переименовать. " +
            "Введите название BankAccountTests и нажмите клавишу ВВОД.Файл BankAccountTests.cs теперь содержит следующий код:";
        [TestMethod()]
        public void ReplaceHelper_gettingClearedTest()
        {
            ReplaceHelper helper = new ReplaceHelper(textForTesting);
            string clearingText = helper.getClearedText();
            bool containsDots = clearingText.Contains('.');
            bool containsZap = clearingText.Contains(',');
            bool containsAl = clearingText.Contains('!');
            bool containsQuest = clearingText.Contains('?');
            Assert.IsFalse(containsDots);
            Assert.IsFalse(containsZap);
            Assert.IsFalse(containsAl);
            Assert.IsFalse(containsQuest);
        }

        [TestMethod()]
        public void ReplaceHelper_gettingThirdArray()
        {
            ReplaceHelper helper = new ReplaceHelper(textForTesting);
            string[] thirdArray = helper.getThirdWordsArray();
            Assert.AreEqual(3, thirdArray.Length);
        }
    }
}