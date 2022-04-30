using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxMath.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void Circle_GetAreaTest_1()
        {
            Circle c = new Circle(4);
            Assert.AreEqual<float>(50.265482f, c.GetArea());
        }

        [TestMethod()]
        public void Circle_GetAreaTest_2()
        {
            Circle c = new Circle(10);
            Assert.AreEqual<float>(314.15926535f, c.GetArea());
        }

        [TestMethod()]
        public void Circle_GetAreaTest_3()
        {
            // Проверка работы исключений
            try
            {
                Circle c = new Circle(-5);
            }
            catch
            {
                return;
            }
            Assert.Fail();
        }
    }
}