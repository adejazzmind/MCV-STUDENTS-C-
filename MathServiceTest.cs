using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcDemo.Services;

namespace MvcDemo.Tests
{
    [TestClass]
    public class MathServiceTests
    {
        private MathService _math;

        [TestInitialize]
        public void Setup()
        {
            _math = new MathService();
        }

        [TestMethod]
        public void Add_ReturnsSum()
        {
            var result = _math.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_Throws()
        {
            _math.Divide(10, 0);
        }
    }
}

