using AtividadeAutomação.PageControler;
using AtividadeAutomação.Testes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace AtividadeAutomação
{
    [TestClass]
    public class UnibrasilTeste : UniTestes
    {
        [TestMethod]
        public void TestMethod1()
        {
            UniControl.ClickOpcaoEsqueceu();
            UniControl.SetInputNome("Willian");
            UniControl.SetInputEmail("testeunicontrol@mailinator.com");
            UniControl.SetInputCPF("09424850921");
            UniControl.BtnOk();
        }
    }
}
