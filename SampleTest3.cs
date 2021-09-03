using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SauceLabsTestProject
{
    public class SampleTests3
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
        public void TestGanttPagelink2()
        {
            GoToPage2();
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink3()
        {
            GoToPage2();
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink4()
        {
            GoToPage2();
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void TestGanttPagelink5()
        {
            GoToPage2();
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        private bool IsDisplayed(By element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1)) { PollingInterval = TimeSpan.FromMilliseconds(250) };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException), typeof(WebDriverException));
            return wait.Until(x => driver.FindElement(element)).Displayed == true;
        }

        private bool IsDisplayedWthoutWait(By element)
        {
            return (driver.FindElement(element)).Displayed;
        }

        private void WaitForPageToLoad()
        {
            bool currentdaymarker_Displayed = IsDisplayed(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            Console.WriteLine($"Purple line displayed:{currentdaymarker_Displayed}");
        }       

        public void GoToPage2()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/2/task");
            Thread.Sleep(TimeSpan.FromMinutes(1));           
                try
                {
                    WaitForPageToLoad();
                }
                catch (Exception e)
                {
                 driver.Navigate().Refresh();
                 Console.WriteLine(e.StackTrace);
                 throw;                    
                }
           
        }
    }
}