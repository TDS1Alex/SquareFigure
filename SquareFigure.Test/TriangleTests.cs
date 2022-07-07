using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;


namespace SquareFigure.Test
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleSquareTest ()
        {
            Triangle triangle = new Triangle(5, 5, 5);
            double expected = 10.825317547305483;

            double actual = triangle.Square();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeSideTest()
        {
            Triangle triangle = new Triangle(-5, 5, 5);
            double actual = triangle.Square();
        }
    }
}
