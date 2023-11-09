using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [DataRow(-3, 4, 1)]
        [DataRow(0, 4, 4)]
        [DataTestMethod]
        public void SumTest(int a, int b, int result)
        {
            Assert.AreEqual(result, Calculator.Sum(a, b));
        }

        [DataRow(2, 2, 4)]
        [DataRow(0, 4, 0)]
        [DataTestMethod]
        public void MultiplyTest(int a, int b, int result)
        {
            Assert.AreEqual(result, Calculator.Multiply(a, b));
        }
    }
}
