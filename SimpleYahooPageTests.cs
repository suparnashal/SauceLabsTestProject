using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SauceLabsTestProject
{
    public class SimpleYahooPageLoad
    {
        public IWebDriver driver; 

        [SetUp]
        public void Setup()
        {
            new SauceLabsSetup().SetupSauceLabsDriver(TestContext.CurrentContext);
            driver = SauceLabsSetup.webDriver;
        }

        private void CheckForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120)) { PollingInterval = TimeSpan.FromMilliseconds(10) };            
            wait.Until(x => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").ToString() == "complete");
        }

        private bool IsPageLoaded()
        {
            Thread.Sleep(TimeSpan.FromSeconds(60));
            return true;
        }

        [Test]
        public void TestYahooPageLink()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys(Keys.Return);
            Thread.Sleep(TimeSpan.FromMinutes(1));
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("QuoteInfo:" + driver.FindElement(By.Id("quote-header-info")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink2()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink3()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink4()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        [Test]
        public void TestYahooPagelink5()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink6()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink7()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink8()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink9()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink10()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestYahooPagelink11()
        {
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@name='yfin-usr-qry']")).SendKeys("NFLX");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[//*[@id='header-desktop-search-button']]"));
            element.Click();
            CheckForPageLoad();
            Console.WriteLine("Bullish:" + driver.FindElement(By.XPath("//*[contains(text(),'Bullish')][1]")).Displayed);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}