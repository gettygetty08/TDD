using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3,Class1.Add(1,2));
            
        }

        //普通に例外のテストをする場合はこんな感じ
        [TestMethod]
        [ExpectedException(typeof(InputException))]
        public void 例外のテスト()
        {
            Assert.AreEqual(3, Class1.Add(-1, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //chaining Assertionを使うとこんな書き方も
            Class1.Add(1, 2).Is(3);

            //chaining Assertionを使った例外テストの書き方
            var ex = AssertEx.Throws<InputException>(() => Class1.Add(-1, 2));
            Assert.AreEqual("マイナス値は入力できません。", ex.Message);
            ex.Message.Is("マイナス値は入力できません。");
        }

    }
}
