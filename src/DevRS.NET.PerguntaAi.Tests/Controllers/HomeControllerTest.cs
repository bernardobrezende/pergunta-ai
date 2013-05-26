using DevRS.NET.PerguntaAi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpTestsEx;
using System.Web.Mvc;

namespace DevRS.NET.PerguntaAi.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            result.Should().Not.Be.Null();
        }       
    }
}