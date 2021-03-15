using System;
using Xunit;

namespace Bonus1.Tests
{
    public class GradeCalculatorTests
    {
        [Fact]
        public void Test_A()
        {
            var converter = new GradeCalculator();

            var testA = converter.Convert(90);

            Assert.Equal("A", testA);
        }

        [Fact]
        public void Test_B()
        {
            var converter = new GradeCalculator();

            var testB = converter.Convert(83);

            Assert.Equal("B", testB);
        }
        [Fact]
        public void Test_C()
        {
            var converter = new GradeCalculator();

            var testC = converter.Convert(73);

            Assert.Equal("C", testC);
        }
        [Fact]
        public void Test_D()
        {
            var converter = new GradeCalculator();

            var testD = converter.Convert(63);

            Assert.Equal("D", testD);
        }
        [Fact]
        public void Test_F()
        {
            var converter = new GradeCalculator();

            var testF = converter.Convert(53);

            Assert.Equal("F", testF);
        }


    }
}
