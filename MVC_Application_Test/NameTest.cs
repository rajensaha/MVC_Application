using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MVC_Application_Test
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public void CheckName()
        {
            string Name = "Rajen";
            Assert.AreEqual(Name, "Rajen");
        }

        [TestMethod]
        public void CheckSurName()
        {
            string SurName = "Saha";
            Assert.AreEqual(SurName, "Saha");
        }
    }
}
