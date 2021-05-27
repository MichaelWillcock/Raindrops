using NUnit.Framework;
using Raindrops;

namespace RaindropsTest
{
    public class Tests
    {
        [TestCase(3, "Pling")]
        [TestCase(5, "Plang")]
        [TestCase(7, "Plong")]
        [TestCase(15, "PlingPlang")]
        [TestCase(35, "PlangPlong")]
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(2, "2")]
        public void BasicFunctionality(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(28, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(34, "34")]
        public void BriefExampleTests(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(-3, "Pling")]
        [TestCase(-5, "Plang")]
        [TestCase(-7, "Plong")]
        [TestCase(-15, "PlingPlang")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(-2, "-2")]
        public void NegativeCases(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(int.MaxValue, "2147483647")]
        [TestCase(int.MinValue, "-2147483648")]
        public void ExtremeValues(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(0, "PlingPlangPlong")]
        public void ZeroTestCase(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}