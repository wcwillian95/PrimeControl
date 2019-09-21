using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projeto_Prime.PageObjects;

namespace Projeto_Prime.PageControler
{    
    public class GoogleControler : GooglePage
    {
        // declarando o objeto e instanciando no objeto Driver

        public static void SetInputGoogle(string text)
        {

            driver.FindElement(inputGoogle()).SendKeys(text + Keys.Enter);
        }

        public static void ClickOpcaoUnibrasil()
        {
            driver.FindElement(OpcaoUnibrasil()).Click();
        }
    }
}
