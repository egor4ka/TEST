using System;
using System.Linq;
using Xunit;
using TEST;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            double a = 10;
            double b = 5;
            Cl adbf = new Cl();
            Assert.True(adbf.Divide(a, b));
        }
        [Fact]

        public void TestMethod2()
        {
            double a = 10;
            double b = 0;
            Cl adbf = new Cl();
            Assert.Throws<DivideByZeroException>(()=>adbf.Divide(a,b));
        }
        [Theory]
        [InlineData(6, 3)]
        [InlineData(12, 2)]
        [InlineData(-12, -2)]
        [InlineData(12, -2)]
        public void TestMethod3(double a,double b)
        {
            Cl adbf = new Cl();
            Assert.True(adbf.Divide(a, b));
        }
        [Theory]
        [InlineData(3, 2)]
        [InlineData(12, 7)]
        [InlineData(-12, -5)]
        [InlineData(1, -2)]
        public void TestMethod4(double a, double b)
        {
            Cl adbf = new Cl();
            Assert.False(adbf.Divide(a, b));
        }

    }
 }
