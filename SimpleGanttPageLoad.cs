using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SauceLabsTestProject
{
    public class SimpleGanttPageLoad
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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60)) { PollingInterval = TimeSpan.FromMilliseconds(10) };            
            wait.Until(x => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").ToString() == "complete");
        }

        private bool IsPageLoaded()
        {
            Thread.Sleep(TimeSpan.FromSeconds(70));
            if (driver.FindElement(By.CssSelector("div.e-custom-event-marker")).Displayed == true)
                return true;
            else
                return false;
        }

        [Test]
        public void TestGanttPagelink()
        {
            //driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            driver.Url = "https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task";
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink2()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink3()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink4()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        [Test]
        public void TestGanttPagelink5()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink6()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink7()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink8()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink9()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink10()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink11()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/task");
            //Thread.Sleep(TimeSpan.FromMinutes(1));
            CheckForPageLoad();
            IsPageLoaded();
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}