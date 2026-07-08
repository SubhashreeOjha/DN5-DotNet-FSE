using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    public class Tests
    {
        private MathLibrary math;

        [SetUp]
        public void Setup()
        {
            math = new MathLibrary();
        }

        [Test]
        public void TestAdd()
        {
            Assert.That(math.Add(10, 20), Is.EqualTo(30));
        }

        [Test]
        public void TestSub()
        {
            Assert.That(math.Sub(20, 10), Is.EqualTo(10));
        }

        [Test]
        public void TestMul()
        {
            Assert.That(math.Mul(10, 5), Is.EqualTo(50));
        }

        [Test]
        public void TestDiv()
        {
            Assert.That(math.Div(20, 5), Is.EqualTo(4));
        }
    }
}