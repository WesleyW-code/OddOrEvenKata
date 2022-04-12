using NUnit.Framework;

namespace OddOrEvenTests
{
    [TestFixture]
    public class OddOrEven_Tests
    {
        [Test]
        public void OddOrEven_UsingNegative_Nums()
        {
            int[] Array = new int[] { 0, -1, -5 };
            Assert.AreEqual("Even", OorE.OddOrEven(Array));

        }
        [Test]
        public void OddOrEven_UsingPositive_Nums()
        {
            int[] Array = new int[] { 0, 1, 4 };
            Assert.AreEqual("Odd", OorE.OddOrEven(Array));

        }
        [Test]
        public void OddOrEven_UsingEmpty_Array()
        {
            int[] Array = new int[] { };
            Assert.AreEqual("Even", OorE.OddOrEven(Array));

        }
        [Test]
        public void OddOrEven_UsingOneNum()
        {
            int[] Array = new int[] { 1};
            Assert.AreEqual("Odd", OorE.OddOrEven(Array));

        }
    }
}