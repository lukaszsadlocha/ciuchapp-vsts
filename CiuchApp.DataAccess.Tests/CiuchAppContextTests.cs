using System;
using CiuchApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuchApp.DataAccess.Tests
{
    [TestClass]
    public class CiuchAppContextTests
    {
        [TestMethod]
        public void CiuchAppContext_CreateContext()
        {
            var current = new CiuchAppDummyContext();
            Assert.IsNotNull(current);
        }


        [TestMethod]
        public void GetNameOfT_Test()
        {
            var name = GetDropdown<BusinessTrip>();

            Assert.AreEqual(name, "BusinessTrip");

        }

        private string GetDropdown<T>()
        {
            string nameOfController = typeof(T).Name;
            return nameOfController;

        }

    }
}
