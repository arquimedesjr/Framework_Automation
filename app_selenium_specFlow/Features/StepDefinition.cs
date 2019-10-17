using System;
using TechTalk.SpecFlow;
using Model_Selenium_SpecFlow.Features;
using Model_Selenium_SpecFlow.Object;
using OpenQA.Selenium;
using System.Threading;

namespace Model_Selenium_SpecFlow
{


    [Binding]
    public class StepDefinition
    {
        private readonly Logic logic = new Logic();
        readonly TelaHome _telaHome = new TelaHome();
        public String _url = "https://www.voegol.com.br/pt";

        [BeforeScenario]
        public void Init()
        {
            logic.SetUp();
        }

        [AfterScenario]
        public void Close()
        {
            logic.CloseApp();
        }

        [Given(@"acesso ao site GOL")]
        public void DadoAcessoAoSiteGOL()
        {
            logic.GetURL(_url);
            logic.Screenshot();
        }

        [Obsolete]
        [When(@"preencho o campo Origem")]
        public void QuandoPreenchoOCampoOrigem()
        {
            logic.Click(_telaHome.Btn_digiteOrigem);
            logic.SendKey(_telaHome.Txt_digiteOrigem, "SDU");
            logic.Click(_telaHome.Grid_origem);
            logic.Screenshot();
        }


        [Obsolete]
        [When(@"preencho o campo Destino")]
        public void QuandoPreenchoOCampoDestino()
        {
            logic.Click(_telaHome.Btn_digiteDestino);
            logic.SendKey(_telaHome.Txt_digiteDestino, "GRU");
            logic.Click(_telaHome.Grid_destino);
            logic.Screenshot();
        }

        [Obsolete]
        [When(@"clico no botão Compre aqui")]
        public void QuandoClicoNoBotaoComprarPassagem()
        {
            logic.Click(By.XPath("//button[@id='btn-box-buy']"));
            logic.Screenshot();
        }

        [Obsolete]
        [When(@"seleciono Data da Ida Dia atual mais um e Data da Volta dois messes após data\.")]
        public void QuandoSelecionoDataDaIdaDiaAtualMaisUmEDataDaVoltaDoisMessesAposData_()
        {
            logic.Click(_telaHome.Btn_data_ida);
            logic.DateDay("1");
            Thread.Sleep(1000);
            logic.Click(_telaHome.Btn_data_volta);
            logic.Click(_telaHome.Grid_proximo);
            logic.DateDay(null);
            logic.MouseOver(By.XPath("//div[@class='box-numbers adults']//div[@class='data']"), By.XPath("//div[@class='box-numbers adults']//a[@class='numbers-add']"));
            logic.Screenshot();
        }
        [When(@"clico no campo Melhor Combo da Tarifa Ligth")]
        public void QuandoClicoNoCampoMelhorComboDaTarifaLigth() 
        {

            logic.ScrollObject(By.XPath("//div[@class='fare-combo-closed light-border']"));
            logic.Click(By.XPath("//div[@class='fare-combo-closed light-border']"));
            logic.Screenshot();
        }

        [Then(@"Valido os campos do Melhor Combo da Tarifa Ligth")]
        public void EntaoValidoOsCamposDoCombo()
        {
            logic.ScrollObject(By.XPath("//h2[contains(text(),'Voo de VOLTA')]"));
            logic.Validacion(By.XPath("//h1[contains(text(),'Confira o melhor preço na')]"));
            logic.Validacion(By.XPath("//div[contains(text(),'IDA')]"));
            logic.Validacion(By.XPath("//div[contains(text(),'VOLTA')]"));
            logic.Validacion(By.XPath("//button[@class='buy-button']"));
            logic.Screenshot();
        }




    }
}

