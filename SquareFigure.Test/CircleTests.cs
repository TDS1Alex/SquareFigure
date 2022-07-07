using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void SquareCircleTest()
        {
            Circle circle = new Circle(5);
            double expected = 78.53981633974483;

            double actual = circle.Square(); 

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeRadiusTest()
        {
            Circle circle = new Circle(-5);
            double actual = circle.Square();           
        }
    }
}