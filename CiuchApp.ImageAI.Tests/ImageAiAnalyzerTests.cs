using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuchApp.ImageAI.Tests
{
    [TestClass]
    public class ImageAiAnalyzerTests
    {
        [TestMethod]
        public void ImageAiAnalyzer_WrongImage()
        {
            var response = CiuchApp.ImageAI.ImageAiAnalyzer.Main();

            Assert.AreEqual(response, "OK");
        }
    }
}
