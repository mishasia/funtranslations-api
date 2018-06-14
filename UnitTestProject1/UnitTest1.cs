using System;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecrutTask.Controllers;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new HomeController();
            var result = controller.GetInput() as ViewResult;
            Assert.IsNotNull(result);
        }


    }
}
