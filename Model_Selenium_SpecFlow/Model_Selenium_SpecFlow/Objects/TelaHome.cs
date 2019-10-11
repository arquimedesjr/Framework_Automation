using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Model_Selenium_SpecFlow.Object
{
    class TelaHome
    {
        public By Btn_digiteOrigem = By.XPath("//div[@class='purchase-box-header-division division-input division-input-origin']//div[@class='chosen-container chosen-container-single']");
        public By Txt_digiteOrigem = By.XPath("//input[@id='header-chosen-origin']");
        public By Btn_digiteDestino = By.XPath("//div[@class='input-destiny division-input-destiny-city active']//div[@class='chosen-container chosen-container-single']");
        public By Txt_digiteDestino = By.XPath("//input[@id='header-chosen-destiny']");
        public By Grid_origem_destino = By.XPath("//div[@class='chosen-drop show-results']//ul[@class='chosen-results']");
        public By Grid_destino = By.XPath("//li[contains(text(),'São Paulo')]");
        public By Grid_origem = By.XPath("//li[contains(text(),'Rio de Janeiro')]");
        public By Btn_checkIn = By.XPath("//*[contains(text(), 'Check-in')]");
        public By Btn_comprarPassagem = By.XPath("//a[@class='btn-buy-passage btn-purchase-header']");
        public By Btn_ida = By.XPath("//*[contains(text(), 'Ida')]");
        public By Btn_data_volta = By.XPath("//div[@class='box-numbers calendar-back']//div[@class='data']");
        public By Btn_data_ida = By.XPath("//div[@class='box-numbers calendar-go']//div[@class='data']");
        public By Grid_data = By.XPath("//*[contains(@class,'ui-datepicker-group ui-datepicker-group-last')]//a[contains(text(),'12')]");
        public By Grid_proximo = By.XPath("//div[@class='ui-datepicker-group ui-datepicker-group-last']");
    
    
    
    }   
}
