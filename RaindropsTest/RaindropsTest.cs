using NUnit.Framework;
using Raindrops;

namespace RaindropsTest
{
    public class Tests
    {
        [TestCase(3, "Pling")]
        [TestCase(-3, "Pling")]
        [TestCase(12, "Pling")]
        public void PositiveandNegativeMultiplesOf3ReturnPling(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(5, "Plang")]
        [TestCase(-5, "Plang")]
        [TestCase(20, "Plang")]
        public void PositiveandNegativeMultiplesOf5ReturnPlang(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(7, "Plong")]
        [TestCase(-7, "Plong")]
        [TestCase(28, "Plong")]
        public void PositiveandNegativeMultiplesOf7ReturnPlong(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(15, "PlingPlang")]
        [TestCase(-15, "PlingPlang")]
        [TestCase(30, "PlingPlang")]
        public void PositiveandNegativeMultiplesOf3And5ReturnPlingPlang(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(-21, "PlingPlong")]
        [TestCase(63, "PlingPlong")]
        public void PositiveandNegativeMultiplesOf3And7ReturnPlingPlong(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(70, "PlangPlong")]
        public void PositiveandNegativeMultiplesOf5And7ReturnPlangPlong(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(105, "PlingPlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(210, "PlingPlangPlong")]
        public void PositiveandNegativeMultiplesOf3And5And7ReturnPlingPlangPlong(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(1, "1")]
        [TestCase(-1, "-1")]
        [TestCase(4, "4")]
        public void PositiveandNegativeIntegersWithNoMultiplesReturnStringsOfCorrespondingDigits(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(int.MaxValue, "2147483647")]
        [TestCase(int.MinValue, "-2147483648")]
        public void ExtremeValuesWithNoMultipleReturnStringOfDigits(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(0, "PlingPlangPlong")]
        public void ZeroBeingAUniversalMultipleReturnsPlingPlangPlong(int input, string expected)
        {
            var actual = Program.RaindropsMethod(input);
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}