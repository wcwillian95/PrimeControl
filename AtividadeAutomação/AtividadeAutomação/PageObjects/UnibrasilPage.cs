using AtividadeAutomação.Testes;
using OpenQA.Selenium;

namespace AtividadeAutomação.PageObjects
{
    public class UnibrasilPage : UniTestes
    {
        public static By BtnEsqueceu()
        {
            return By.CssSelector("input[id='usuario'][class='form-control input-round']");
        }

        public static By InputUsuario()
        {
            return By.XPath("(//input[@name='txtUsuario'])[2]");
        }
        public static By InputEmail()
        {
            return By.XPath("//input[@id='email']");
        }
        public static By InputCPF()
        {
            return By.XPath("(//input[@id='usuario'])[1]");
        }
        public static By BtnOK()
        {
            return By.XPath("(//button[@class='btn btn-success'])[1]");
        }
    }
}
