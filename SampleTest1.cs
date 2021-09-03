using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SauceLabsTestProject
{
    [TestFixture]
    public class SampleTests1
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
            GoToPage1();            
            bool currentdaymarker_Displayed = IsDisplayed(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            Console.WriteLine($"Purple line displayed:{currentdaymarker_Displayed}");
        }


        [Test]
        public void TestGanttPagelink2()
        {
            GoToPage2();
            bool currentdaymarker_Displayed = IsDisplayed(By.XPath("//*[contains(@class,'e-custom-event-marker')]"));
            Console.WriteLine($"Purple line displayed:{currentdaymarker_Displayed}");
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
            int polling = 20, maxtime = 60, elapsed = 0;
            bool currentDayMarker = false; ;
            do
            {
                try
                {
                    if (driver.FindElement(By.XPath("//*[@title='Find a task']")) != null)
                        currentDayMarker = true;
                }
                catch (Exception e)
                {
                    currentDayMarker = false;
                    Thread.Sleep(TimeSpan.FromSeconds(polling));
                    elapsed += polling;
                }
                
            } while (currentDayMarker == false && elapsed < maxtime);            
        }


        public void GoToPage1()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/2/task");

            Thread.Sleep(TimeSpan.FromMinutes(1));

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    WaitForPageToLoad();
                }
                catch (Exception e)
                {
                    if (i < 2)
                    {
                        driver.Navigate().Refresh();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(e.StackTrace);
                        throw;
                    }
                }
            }
        }

        public void GoToPage2()
        {
            driver.Navigate().GoToUrl("https://mc-adsqaweb02.bstsoftware.net:444/project/ca00dde5-a981-08d3-e007-bfd4dea8627c/2/task");
            Thread.Sleep(TimeSpan.FromMinutes(1));          
        }
    }
}