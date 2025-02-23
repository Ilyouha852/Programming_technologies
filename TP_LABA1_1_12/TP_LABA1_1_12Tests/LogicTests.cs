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
        public void ConvertorTest()
        {
            //В этом тесте метод Convertor должен вывести "1 рубль"
            int cost = 100;
            var message = Logic.Convertor(cost);
            Assert.AreEqual("1 рубль", message);
        }

        [TestMethod()]
        public void ConvertorTest1()
        {
            //В этом тесте метод Convertor должен вывести "1 копейка"
            int cost = 1;
            var message = Logic.Convertor(cost);
            Assert.AreEqual("1 копейка", message);
        }

        [TestMethod()]
        public void ConvertorTest2()
        {
            //В этом тесте метод Convertor должен вывести "1 рубль, 1 копейка"
            int cost = 101;
            var message = Logic.Convertor(cost);
            Assert.AreEqual("1 рубль, 1 копейка", message);
        }

        [TestMethod()]
        public void ConvertorTest3()
        {
            //В этом тесте метод Convertor должен вывести "2 рубля"
            int cost = 200;
            var message = Logic.Convertor(cost);
            Assert.AreEqual("2 рубля", message);
        }

        [TestMethod()]
        public void ConvertorTest4()
        {
            //В этом тесте метод Convertor должен вывести "2 копейки"
            int cost = 2;
            var message = Logic.Convertor(cost);
            Assert.AreEqual("2 копейки", message);
        }

        [TestMethod()]
        public void ConvertorTest5()
        {
            //В этом тесте метод Convertor должен вывести "3 рубля, 4 копейки"
            int cost = 304;
            var message = Logic.Convertor(cost);
            Assert.AreEqual("3 рубля, 4 копейки", message);
        }

        [TestMethod()]
        public void ConvertorTest6()
        {
            //В этом тесте метод Convertor должен вывести "11 рублей, 5 копеек"
            int cost = 1105;
            var message = Logic.Convertor(cost);
            Assert.AreEqual("11 рублей, 5 копеек", message);
        }
    }
}