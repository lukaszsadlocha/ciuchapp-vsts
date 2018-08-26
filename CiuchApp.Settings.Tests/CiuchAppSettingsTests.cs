using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CiuchApp.Settings;

namespace CiuchApp.Settings.Tests
{
    [TestClass]
    public class CiuchAppSettingsFactoryTests
    {
        [TestMethod]
        public void GetSettings_Test()
        {
            var settings = Settings.CiuchAppSettingsFactory.GetSettings();

            Assert.IsNotNull(settings);

        }
    }
}
