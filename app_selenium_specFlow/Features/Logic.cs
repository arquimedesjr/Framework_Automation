using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using System.Threading;


namespace Model_Selenium_SpecFlow.Features
{
    class Logic
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private static int contador = 1;

        public void SetUp()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Program Files (x86)\Google\Chrome\Application", "chromedriver.exe");
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            _driver = new ChromeDriver(service, options);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
        }

        public void CloseApp()
        {
            _driver.Quit();
    
        }

        public void GetURL(String url)
        {
            _driver.Navigate().GoToUrl(url);
        }

    
        public void Click(By by)
        {
            WaitObject(by);
            _driver.FindElement(by).Click();
        }

        public void WaitObject(By by) 
        {
            try
            {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));

            }
            catch (Exception e)
            {
                try
                {
                    _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(by));

                }
                catch (Exception e2)
                {
                    try
                    {

                    _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
                    }catch(Exception e3)

                    {
                        Console.WriteLine(e3);
                    }

                }
            }
        }


        [Obsolete]
        public void SendKey(By by, String _string)
        {
            WaitObject(by);
            _driver.FindElement(by).Clear();
            _driver.FindElement(by).SendKeys(_string);
        }

        [Obsolete]
        public void Select(By by, String _string)
        {
            WaitObject(by);
            IWebElement _element = _driver.FindElement(by);
            new SelectElement(_element).DeselectByText(_string);
        }


        public void DateDay(String qnt)
        {
            if (qnt != null)
            {
            int dia = int.Parse(DateTime.Now.ToString("dd"));
            dia += int.Parse(qnt);
            String diaMaisUm = dia.ToString(); 
            Click(By.XPath("//*[contains(@class,'ui-datepicker-group ui-datepicker-group-first')]//a[contains(text(),'" + diaMaisUm + "')]"));

            }
            else
            {
                String dia = DateTime.Now.ToString("dd");

                Click(By.XPath("//*[contains(@class,'ui-datepicker-group ui-datepicker-group-last')]//a[contains(text(),'" + dia + "')]"));
            }

        }
        public void Validacion(By by)
        {
            WaitObject(by);
        }


        public void Screenshot()
        {
            ITakesScreenshot camera = _driver as ITakesScreenshot;
            Screenshot foto = camera.GetScreenshot();
            string cont = contador.ToString();
            string screenshotsPasta = @"C:\Users\qui_j\Documents\Desenvolvimento\C#\Evidencia\" + "Imagem_" + cont+ ".png";
            foto.SaveAsFile(screenshotsPasta, ScreenshotImageFormat.Png);
            contador++;
        }


        public void MouseOver(By by, By submenu)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));

            Actions action = new Actions(_driver);
            action.MoveToElement(element).Click().Build().Perform();

            IWebElement FirstmenuAdmin = element.FindElement(submenu);

            action.MoveToElement(FirstmenuAdmin).Click().Build().Perform();
        }
        public void ScrollObject(By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));

            Actions action = new Actions(_driver);
            action.MoveToElement(element).Click().Build().Perform();

        }


    }


   
}
