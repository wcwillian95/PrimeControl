using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Projeto_Prime.PageControler;

namespace Projeto_Prime
{
    [TestClass]
    public class GoogleTeste : TesteBase
    {
        [TestMethod]
        public void PesquisaGoogle()
        {           
            

            GoogleControler.SetInputGoogle("Speed Test Copel");
            GoogleControler.ClickOpcaoUnibrasil();



            //// instanciar o objeto Driver
            ////ChromeDriver Driver = new ChromeDriver();

            //// declarar a URL que será aberta
            //Driver.Navigate().GoToUrl("https://www.google.com");
            //// Abrir a janela maximizada
            //Driver.Manage().Window.Maximize();
            ////Ny.Name está mapeando o elemento selecionado
            ////SendKeys define o parametro que sera enviado
            //Driver.FindElement(By.Name("q")).SendKeys("Speed test Copel" + Keys.Enter);
            //// Driver.FindElement(By.Name("btnK")).Click();
            //Driver.FindElement(By.XPath("//a[@href='http://www.copeltelecom.com/site/speedtest/'])[1]")).Click();

        }
    }
}
