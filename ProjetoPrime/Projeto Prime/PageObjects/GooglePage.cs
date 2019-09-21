using OpenQA.Selenium;

namespace Projeto_Prime.PageObjects
{
    public class GooglePage : TesteBase
    {
        public static By inputGoogle()
        {

            return By.Name("q");
        }
        public static By OpcaoUnibrasil()
        {
            //selciona qual o elemento sera aberto atravez do ID, name, classe, etc
            return By.XPath("//a[@href='http://www.copeltelecom.com/site/speedtest/']");
        }
    }    
}
