using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleWebHalloWorld;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebHalloWorld.Tests
{
    [TestClass()]
    public class ProgramTests : Program
    {
        [TestMethod()]
        public void FakeMethodTest()
        {
            int i = 1;
       
            int a = FakeMethod(i);

            Assert.AreEqual(i++, a);
        }
    }
}