using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.trivago.com.br");
            driver.FindElement(By.XPath("//span[contains(text(),'Criar conta')]")).Click();

            Thread.Sleep(2000);

            driver.Close();
        }
    }
}