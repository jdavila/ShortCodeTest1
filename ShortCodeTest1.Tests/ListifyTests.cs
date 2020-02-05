using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace ShortCodeTest1.Tests
{
    [TestClass]
    public class ListifyTests
    {
        [TestMethod]
        public void ListifyConstructor_IfRangeStartIsGreaterThanRangeEnd_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Listify(200, 100));
        }

        [DataTestMethod]
        [DataRow(1, 2)]
        [DataRow(1, 1)]
        [DataRow(1, 10)]
        public void Listify_WhenIterated_HasRightNumberOfElements(int startValue, int endValue)
        {
            int expectedCount = endValue - startValue + 1;
            var list = new Listify(startValue, endValue);
            int count = 0;

            foreach(int i in list)
                count++;

            Assert.IsTrue(count == expectedCount);
        }

        [TestMethod]
        public void Listify_WhenRequestingElementByIndex_ReturnsTheRightElement()
        {
            var list = new Listify(100, 200);

            int result = list[50];

            Assert.AreEqual(result, 150);
        }
    }
}
