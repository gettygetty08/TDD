using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TDDtest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var val = TDD.UI.Caluculation.Sum(2, 5);
            Assert.AreEqual(7,val);
        }

        [TestMethod]
        public void 平均値取得できる()
        {
            var list = new List<int> {1,2,3,4,5};
            var result = TDD.UI.Caluculation.Ave(list);
            Assert.AreEqual(3,result);
        }
    }
}
