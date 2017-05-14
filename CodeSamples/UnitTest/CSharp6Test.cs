using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeSamples;

namespace UnitTest
{
    [TestClass]
    public class CSharp6Test
    {
        CSharp6 test = new CSharp6();
        [TestMethod]
        public void NullConditionalOPeratorTest()
        {
            test.NullConditionalOPerator();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ExceptionFiltersTest()
        {
            test.ExceptionFilters();
            Assert.IsTrue(true);
        }

    }
}
