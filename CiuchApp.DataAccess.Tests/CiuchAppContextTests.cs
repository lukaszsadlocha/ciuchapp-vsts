using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuchApp.DataAccess.Tests
{
    [TestClass]
    public class CiuchAppContextTests
    {
        [TestMethod]
        public void CiuchAppContext_CreateContext()
        {
            var current = new CiuchAppContext();
            Assert.IsNotNull(current);
        }
    }
}
