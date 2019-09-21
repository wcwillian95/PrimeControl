using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace AtividadeAutomação.Testes
{
    public class UniTestes
    {
        public static ChromeDriver driver;

        [TestInitialize]
        public void Inicio()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://portaluni2.unibrasil.com.br/");
            driver.Manage().Window.Maximize();
        }

        //[TestCleanup]
        //public void Fim()
        //{
        //    driver.Quit();
        //}

    }
}
