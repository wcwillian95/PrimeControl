using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace Projeto_Prime
{
    public class TesteBase
    {
        public static ChromeDriver driver;

        [TestInitialize]
        public void inicio()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void fim()
        {
            driver.Quit();
        }
    }
}
