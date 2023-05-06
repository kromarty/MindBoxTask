using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getRoundAreaTest()
        {
            double r = 10.5;
            double expectedArea = 346.185;
            Figure round = new Round(r);
            Assert.AreEqual(round.getArea(), expectedArea);
        }

        [TestMethod]
        public void getTriangleAreaTest() {
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedArea = 6;
            Figure triangle = new Triangle(a, b, c);
            Assert.AreEqual(triangle.getArea(), expectedArea);
        }

        [TestMethod]
        public void isSquareTestTrue()
        {
            double a = 3;
            double b = 5;
            double c = 4;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(triangle.isSquare(), true);
        }
    }
}