using DTD.Calculator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DTD.Calculator.Tests
{
    [TestClass]
    public class RealNumberTest
    {
        private void Test(string op, int a, int b, int c)
        {
            var operation = OperationFactory<RealNumber>.Instance.GetOperation(op);
            var r0 = new RealNumber(a);
            var r1 = new RealNumber(b);
            var r2 = new RealNumber(c);
            var r3 = operation.Operate(r1, r2);
            Assert.IsTrue(RealNumber.IsEquals(r0, r3));
        }


        [TestMethod]
        public void TestAdd()
        {
            Test("+", 5, 2, 3);
        }


        [TestMethod]
        public void TestSubstract()
        {
            Test("-", 5, 10, 5);
        }


        [TestMethod]
        public void TestMultiply()
        {
            Test("*", 2, 2, 1);
        }


        [TestMethod]
        public void TestDiv()
        {
            Test("/", 10, 100, 10);
        }
    }
}