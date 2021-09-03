using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SauceLabsTestProject
{
    public class SampleTests2
    {
        public IWebDriver driver; 

        [SetUp]
        public void Setup()
        {
            new SauceLabsSetup().SetupSauceLabsDriver(TestContext.CurrentContext);
            driver = SauceLabsSetup.webDriver;
        }

        [Test]
        public void TestGoogleLink()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");            
        }

        [Test]
        public void TestGanttPagelink()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/2/task");
            Thread.Sleep(TimeSpan.FromMinutes(1));
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink2()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/2/task");
            Thread.Sleep(TimeSpan.FromMinutes(1));
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink3()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/2/task");
            Thread.Sleep(TimeSpan.FromMinutes(1));
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink4()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/2/task");
            Thread.Sleep(TimeSpan.FromMinutes(1));
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        [Test]
        public void TestGanttPagelink5()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/2/task");
            Thread.Sleep(TimeSpan.FromMinutes(1));
            driver.FindElement(By.XPath("//*[@title='Find a task']"));
            driver.FindElement(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}