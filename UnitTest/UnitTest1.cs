using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_Practical_9.Controllers;
using System;
using System.Web.Mvc;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController homeController = new HomeController();

            ViewResult test3 = homeController.Test3() as ViewResult;

            Assert.AreEqual("Hello World", test3.ViewData["Message"]);
        }
    }
}
