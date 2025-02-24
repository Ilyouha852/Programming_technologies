using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void haveSameLettersTest()
        {
            string word1 = "процессор";
            string word2 = "информация";

            string msg = Logic.haveSameLetters(word1, word2);

            Assert.AreEqual("нет да да да нет нет ", msg);
        }

        [TestMethod()]
        public void haveSameLettersTest1()
        {
            string word1 = "Привет";
            string word2 = "пока";

            string msg = Logic.haveSameLetters(word1, word2);

            Assert.AreEqual("нет нет нет нет нет нет ", msg);
        }
    }
}