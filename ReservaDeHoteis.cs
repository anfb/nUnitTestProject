using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace Tests
{
    public class ReservaDeHoteis

    {
        private IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
             driver.Navigate().GoToUrl("https://www.trivago.com.br/");
        }

        [Test]
        public void BucarHotel()
        {
            Thread.Sleep(5000);
            IWebElement searchElement = driver.FindElement(By.Id("querytext"));
            searchElement.Clear();
            searchElement.SendKeys("Natal");
            
            driver.FindElement(By.CssSelector(".dealform-button--guests .dealform-button__head")).Click();
		    driver.FindElement(By.XPath("//span[contains(text(),'Individual')]")).Click();
            driver.FindElement(By.XPath("//span[@class='search-button__label']")).Click();
            
           
            
    
        }


        [TearDown]
        public void finish(){
            driver.Close();
        }
    }
}