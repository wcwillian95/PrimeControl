using AtividadeAutomação.PageObjects;
using OpenQA.Selenium;

namespace AtividadeAutomação.PageControler
{
    public class UniControl: UnibrasilPage
    {
        public static void ClickOpcaoEsqueceu()
        {
            driver.FindElement(BtnEsqueceu()).Click();
        }
        public static void SetInputNome(string nome)
        {
            driver.FindElement(InputUsuario()).SendKeys(nome + Keys.Tab);
        }
        public static void SetInputEmail(string email)
        {
            driver.FindElement(InputEmail()).SendKeys(email + Keys.Tab);
        }
        public static void SetInputCPF(string CPF)
        {
            driver.FindElement(InputCPF()).SendKeys(CPF);
        }
        public static void BtnOk()
        {
            driver.FindElement(BtnOK()).Click();
        }

    }
}
