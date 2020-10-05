using NUnit.Framework;

namespace MathUtilsTest
{
    public class MathTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuccess()
        {
            int result = MathUtils.Math.factorial(3);
            Assert.AreEqual(6, result);
        }
    }
}