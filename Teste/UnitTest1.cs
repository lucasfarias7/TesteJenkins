﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Worlds", Program.Mensagem());
        }
    }
}
