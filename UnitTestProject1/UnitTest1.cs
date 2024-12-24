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
            Assert.Equal(2, adbf.Divide(a, b));
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
        [InlineData(6, 3, 2)]
        [InlineData(12, 2, 6)]
        public void TestMethod3(double a,double b ,double exp)
        {
            Cl adbf = new Cl();
            Assert.Equal(exp, adbf.Divide(a, b));
        }

    }
 }
