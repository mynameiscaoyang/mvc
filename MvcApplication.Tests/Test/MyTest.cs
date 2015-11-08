using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.Tests.Test
{
    [TestClass]
    public class MyTest
    {
        [TestMethod]
        public void testString()
        {
            String temp = "caoyang";
            Assert.AreEqual("caoyang", temp);
        }
    }
}
