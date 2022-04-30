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
    public class TriangleTests
    {
        [TestMethod()]
        public void Triangle_GetAreaTest_1()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.AreEqual<float>(6, t.GetArea());
        }

        [TestMethod()]
        public void Triangle_GetAreaTest_2()
        {
            // Проверка работы исключений
            try
            {
                Triangle t = new Triangle(2, 2, -6);
            }
            catch
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void Triangle_GetAreaTest_3()
        {
            // Проверка работы исключений
            try
            {
                Triangle t = new Triangle(0, 0, 1);
            }
            catch
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void Triangle_GetAreaTest_4()
        {
            Triangle t = new Triangle(10, 10, 10);
            Assert.AreEqual<float>(43.30127f, t.GetArea());
        }


        [TestMethod()]
        public void Triangle_IsSquareTest_5()
        {
            Triangle t = new Triangle(10, 10, 10);
            Assert.IsFalse(t.IsSquare());
        }

        [TestMethod()]
        public void Triangle_IsSquareTest_6()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.IsTrue(t.IsSquare());
        }
    }
}